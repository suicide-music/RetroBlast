using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public bool isGameActive = false;
    public GameObject titleScreen;
    public GameObject pauseScreen;
    public GameObject gameOverScreen;
    public GameObject welldoneScreen;
    public TextMeshProUGUI wellDoneScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverScore;



    private bool paused;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PauseGame();
        }

        scoreText.text = "Score: " + score;

    }

    public void StartGame()
    {
        isGameActive = true;
        titleScreen.gameObject.SetActive(false);
        score = 0;



    }

    public void PauseGame()
    {
        if (!paused)
        {
            paused = true;
            pauseScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            paused = false;
            pauseScreen.SetActive(false);
            Time.timeScale = 1;
        }


    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverScreen.gameObject.SetActive(true);
        gameOverScore.text = "Your score: " + score;
    }

    public void GameFinished()
    {
        isGameActive = false;
        welldoneScreen.gameObject.SetActive(true);
        wellDoneScore.text = "Your score: " + score;
    }

}
