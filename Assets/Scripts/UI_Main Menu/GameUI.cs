using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameUI : MonoBehaviour
{
    public Button pauseBtn, popUpCloseBtn, resumeBtn, quitBtn, mainMenuBtn, replayBtn;
    public Toggle /*soundToggle,*/ musicToggle;
    public GameObject popUpPanel;
    public AudioSource musicAudio /*enemySoundAudio, playerSoundAudio*/;

    private CharactersHealth charactersHealth;

    private void Awake()
    {
        pauseBtn.onClick.AddListener(GamePause);
        resumeBtn.onClick.AddListener(GameResume);
        mainMenuBtn.onClick.AddListener(GoToMainMenu);
        quitBtn.onClick.AddListener(QuitGame);
        musicToggle.onValueChanged.AddListener(MusicToggle);
        
        replayBtn.onClick.AddListener(GameReplay);
        popUpCloseBtn.onClick.AddListener(ClosePanel);


        charactersHealth = GetComponent<CharactersHealth>();




    }

    public void GamePause()
    {
        popUpPanel.gameObject.SetActive(true);
        musicAudio.gameObject.SetActive(false);
        Time.timeScale = 0;

        resumeBtn.gameObject.SetActive(true);

    }
    public void GameResume()
    {
        resumeBtn.gameObject.SetActive(false);
        popUpPanel.gameObject.SetActive(false);
        musicAudio.gameObject.SetActive(true);
        Time.timeScale = 1;
    }

    public void GameReplay()
    {
        popUpPanel.gameObject.SetActive(false);
        resumeBtn.gameObject.SetActive(true);
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
   
    public void QuitGame()
    {
        Application.Quit();
    }
     public void ClosePanel()
    {
        popUpPanel.gameObject.SetActive(false);
    }

    public void GamePauseAfterPlayerDied()
    {
        popUpPanel.gameObject.SetActive(true);
        musicAudio.gameObject.SetActive(false);
        Time.timeScale = 0;
        resumeBtn.gameObject.SetActive(false);
        musicToggle.gameObject.SetActive(false);

    }
}
