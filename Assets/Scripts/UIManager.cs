using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("avatarCustomize");

    }
    public void ExitGame()
    {

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;// edit�rde de ��kmas�n� sa�lar
        #endif
        Application.Quit(); // oyun oynarken ��kar oyundan
        
    }
}
