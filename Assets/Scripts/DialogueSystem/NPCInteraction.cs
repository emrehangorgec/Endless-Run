using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCInteraction : MonoBehaviour
{
    public float interactionDistance = 7f;
    public GameObject messagePanel; //dialog object kýsmý olacak
    public GameObject messageTrigger; //e tuþuna basýn triggerý olacak

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log(other.gameObject.tag);
            messageTrigger.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("e tusuna basýldý");
                print("Interact");

                messagePanel.SetActive(true);
                Cursor.visible = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        messageTrigger.SetActive(false);
        messagePanel.SetActive(false);
    }

}
    