using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelnfoMenu : MonoBehaviour
{
    public GameObject levelInfoMenu;
    // Start is called before the first frame update
    void Start()
    {
        levelInfoMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseLevelInfo(){
        levelInfoMenu.SetActive(false);
    }
}
