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
        UnityEditor.EditorApplication.isPlaying = false;// editörde de çýkmasýný saðlar
        #endif
        Application.Quit(); // oyun oynarken çýkar oyundan
        
    }
}
