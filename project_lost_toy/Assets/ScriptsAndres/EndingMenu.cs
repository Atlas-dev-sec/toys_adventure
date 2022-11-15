using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndingMenu : MonoBehaviour
{
    public GameObject endingScreen;
    public string mainMenuScene;
    //private bool gameOver;

    // Update is called once per frame
    void Update()
    {
        if (CarCollisionHandler.gameOver){
            endingScreen.SetActive(true);
        }
    }

    public void RestarPlay(){
        CarCollisionHandler.gameOver = false;
        SceneManager.LoadScene("SceneryOne");
    }

    public void QuitToMainEnding(){
        SceneManager.LoadScene(mainMenuScene);
    }

}
