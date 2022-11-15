using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarCollisionHandler : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 1.0f;
    public GameObject playerMovement;
    [SerializeField] AudioClip explodeSound;
    [SerializeField] AudioClip successSound;
    [SerializeField] ParticleSystem crashParticle;
    [SerializeField] ParticleSystem successParticle;
    AudioSource audioSource;
    bool isTransitioning = false;
    public static bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision other) {
        if (isTransitioning) { return;}

        switch(other.gameObject.tag){
            case "Finish":
            StartSuccessSequence();
            gameOver = true;
            break;

            case "Enemy":
                StartCrashSequence();
                Destroy(other.gameObject, 0.3f);
                break;
            default:
                Debug.Log("Game running");
                break;
        }
    }

    void StartSuccessSequence(){

        isTransitioning = true;
        audioSource.Stop();
        successParticle.Play();
        audioSource.PlayOneShot(successSound);
        GetComponent<PlayerCarController>().enabled = false;
        //Invoke("LoadNextLevel", levelLoadDelay);
    }

    void StartCrashSequence(){
        isTransitioning = true;
        audioSource.Stop();
        crashParticle.Play();
        audioSource.PlayOneShot(explodeSound);
        GetComponent<PlayerCarController>().enabled = false;
        Invoke("ReloadLevel", levelLoadDelay); 
    }

    void ReloadLevel(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // SceneManager.LoadScene("lorem");
        SceneManager.LoadScene(currentSceneIndex);
    }

    void LoadNextLevel(){
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings){
            nextSceneIndex = 0;
        }

        SceneManager.LoadScene(nextSceneIndex);
    }
    
}
