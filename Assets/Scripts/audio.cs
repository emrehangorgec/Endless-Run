using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audio : MonoBehaviour
{
    public Slider slider;

    private void Start()
    {
        LoadAudio();
    }


    public void SetAudio(float value)
    {
        AudioListener.volume = value;
        SaveAudio();
    }
    private void SaveAudio()
    {
        PlayerPrefs.SetFloat("audioVolume", AudioListener.volume);
    }

    private void LoadAudio()//oyun sesi kaydettiðimiz sese eþit oldu
    {
        if(PlayerPrefs.HasKey("audioVolume"))
        { 
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            slider.value = PlayerPrefs.GetFloat("audioVolume");
        }
        else
        {
            PlayerPrefs.SetFloat("audioVolume", 0.5f);
            AudioListener.volume = PlayerPrefs.GetFloat("audioVolume");
            slider.value = PlayerPrefs.GetFloat("audioVolume");
        }
    }
}