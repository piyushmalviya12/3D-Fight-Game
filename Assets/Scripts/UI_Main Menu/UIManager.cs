using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Slider loadingBar;
    public float fillingSpeed = 0.001f;

    public  GameObject splashScreen;
    public  GameObject mainMenuScreen;

    public AudioSource mainMenuSound;

    public Button quitBtn,soundBtn,playBtn;
    public string sceneName;

    private void Awake()
    {
        playBtn.onClick.AddListener(PlayBtn);
        quitBtn.onClick.AddListener(QuitBtn);
        soundBtn.onClick.AddListener(SoundBtn);
        mainMenuSound.Play();

    }
    private void Start()
    {
        
    }
    void FixedUpdate()
    {
        if (loadingBar.value != 1)
        {
            loadingBar.value += fillingSpeed;
        }
        else
        {
            splashScreen.gameObject.SetActive(false);
            mainMenuScreen.gameObject.SetActive(true);
                
        }
    }

    public void PlayBtn()
    {
      
        SceneManager.LoadScene(sceneName);
    }
    public void QuitBtn()
    {
        Application.Quit();
    }
    public void SoundBtn()
    {
        
        mainMenuSound.Pause();
    }

}
