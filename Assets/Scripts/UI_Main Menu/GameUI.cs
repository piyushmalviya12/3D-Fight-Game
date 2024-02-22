using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameUI : MonoBehaviour
{
    public Button pauseBtn, popUpCloseBtn, playBtn, quitBtn, mainMenuBtn, replayBtn;
    public Toggle soundToggle, musicToggle;
    public GameObject popUpPanel;
    public AudioSource musicAudio /*enemySoundAudio, playerSoundAudio*/;

    private void Awake()
    {
        pauseBtn.onClick.AddListener(GamePause);
        playBtn.onClick.AddListener(GameResume);
        mainMenuBtn.onClick.AddListener(GoToMainMenu);
        quitBtn.onClick.AddListener(QuitGame);
        musicToggle.onValueChanged.AddListener(MusicToggle);
        //  soundToggle.onValueChanged.AddListener(SoundToggle);
        replayBtn.onClick.AddListener(GameReplay);
        popUpCloseBtn.onClick.AddListener(ClosePanel);


       
        
    }

    public void GamePause()
    {
        popUpPanel.gameObject.SetActive(true);
        musicAudio.gameObject.SetActive(false);
        Time.timeScale = 0;

    }
    public void GameResume()
    {
        popUpPanel.gameObject.SetActive(false);
        musicAudio.gameObject.SetActive(true);
        Time.timeScale = 1;
    }

    public void GameReplay()
    {
        popUpPanel.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        GameResume();
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void MusicToggle(bool On)
    {
        if (On == true)
        {
            musicAudio.gameObject.SetActive(true);
        }
        if (On == false)
        {
            musicAudio.gameObject.SetActive(false);
        }
    }
    /*public void SoundToggle(bool isOn)
    {
        if (isOn == true)
        {
*//*
            enemySoundAudio.gameObject.SetActive(true);
            playerSoundAudio.gameObject.SetActive(true);*//*

            playerSoundAudio.GetComponent<AudioSource>().gameObject.SetActive(true);
            enemySoundAudio.GetComponent<AudioSource>().gameObject.SetActive(true);

        }
        if (isOn == false)
        {

            *//*     enemySoundAudio.gameObject.SetActive(false);
                 playerSoundAudio.gameObject.SetActive(false);*//*

            playerSoundAudio.GetComponent<AudioSource>().gameObject.SetActive(false);
            enemySoundAudio.GetComponent<AudioSource>().gameObject.SetActive(false);

        }
       


    
      
    }*/
    public void QuitGame()
    {
        Application.Quit();
    }
     public void ClosePanel()
    {
        popUpPanel.gameObject.SetActive(false);
    }


}
