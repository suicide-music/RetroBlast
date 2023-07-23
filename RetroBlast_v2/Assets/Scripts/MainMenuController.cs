using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{

    //public PlayerNameInput playerNameInput;
    public TMP_InputField nameInputField;


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

        DataTransfer.playerName = nameInputField.text;

        LoadSceneByBuildIndex(1);
  

    }

    public void LoadSceneByBuildIndex(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }


}
