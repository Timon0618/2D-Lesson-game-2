using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControls : MonoBehaviour
{

    [SerializeField] private Slider _soundSlider, _musicSlider;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayBtnClick()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitBtnClick()
    {
        Application.Quit();
    }

    public void SetSoundVolume()
    {
        PlayerData.SetSoundVolume(_soundSlider.value);
    }


    public void SetMusicVolume()
    {
        PlayerData.SetMusicVolume(_musicSlider.value);
    }
}
