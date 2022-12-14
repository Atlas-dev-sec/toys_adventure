using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevel;
    public GameObject creditsScreen;
    // Start is called before the first frame update
    void Start()
    {
        creditsScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        SceneManager.LoadScene(firstLevel);
    }

    public void OpenCredits(){
        creditsScreen.SetActive(true);
    }

    public void CloseCredits(){
        creditsScreen.SetActive(false);
    }
    public void QuitGame(){
        Application.Quit();
    }
}
