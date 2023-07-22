using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void StartGameButton()
    {
    LoadSceneByBuildIndex(1);

     }

    public void LoadSceneByBuildIndex(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
}
