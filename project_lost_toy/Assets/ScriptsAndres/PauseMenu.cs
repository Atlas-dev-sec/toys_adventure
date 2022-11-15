using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseScreen;
    public string mainMenuScene;
    private bool isPaused;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            PauseUnpause();
        }
    }

    public void PauseUnpause(){
        if (!isPaused){
            pauseScreen.SetActive(true);
            isPaused = true;
            Time.timeScale = 0.0f;
        }else {
            pauseScreen.SetActive(false);
            isPaused = false;
            Time.timeScale = 1.0f;
        }
    }

    public void QuitToMain(){
        
        SceneManager.LoadScene(mainMenuScene);
        Time.timeScale = 1.0f;
    }
}
