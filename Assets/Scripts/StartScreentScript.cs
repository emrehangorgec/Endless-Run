using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Thirdweb;

public class StartScreentScript : MonoBehaviour
{
    public GameObject ConnectedState;
    public GameObject DiscconectedState;
    public GameObject StartGameState;
    public GameObject ClaimNFTState;
    public GameObject LoadingState;

    string address;
    Contract contract;

    void Start()
    {
        contract = ThirdwebManager.Instance.SDK.GetContract(
            "0x9121b78902572b9EbfaC3718CB78BD6E6d7dd142"
        );
        ConnectedState.SetActive(false);
        DiscconectedState.SetActive(true);
        StartGameState.SetActive(false);
        ClaimNFTState.SetActive(false);
        LoadingState.SetActive(false);
    }

    async public void ConnectWallet()
    {
        address = await ThirdwebManager.Instance.SDK.wallet.Connect();
        ConnectedState.SetActive(true);
        DiscconectedState.SetActive(false);
        WalletNFTBalance();
    }

    public void DiscconectState()
    {
        ConnectedState.SetActive(false);
        DiscconectedState.SetActive(true);
    }

    async public void WalletNFTBalance()
    {
        var NFTbalance = await contract.ERC1155.BalanceOf(address, "0");
        var NFTbalanceInt = int.Parse(NFTbalance);
        if (NFTbalanceInt > 0)
        {
            StartGameState.SetActive(true);
            ClaimNFTState.SetActive(false);
        }
        else
        {
            StartGameState.SetActive(false);
            ClaimNFTState.SetActive(true);
        }
    }

    async public void ClaimNFT()
    {
        ClaimNFTState.SetActive(false);
        LoadingState.SetActive(true);
        var claimResult = await contract.ERC1155.Claim("0", 1);
        if (claimResult.isSuccessful())
        {
            LoadingState.SetActive(false);
            WalletNFTBalance();
        }
        else
        {
            Debug.Log("Failed to claim!");
        }
    }
}
