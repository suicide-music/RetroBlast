using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using System.IO;


public class GameManager : MonoBehaviour
{

    public bool isGameActive = true;
    public GameObject pauseScreen;
    public GameObject gameOverScreen;
    public GameObject welldoneScreen;
    public TextMeshProUGUI wellDoneScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverScore;
    public TextMeshProUGUI lastGameScoreText;


    private bool paused;
    public int score;
    public int lastGameScore;

    private void Start()
    {
        LoadHighScore();
        lastGameScoreText.text = "Previous Game Score: " + lastGameScore;
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
        lastGameScore = score;
        SaveHighScore();
    }

    public void GameFinished()
    {
        isGameActive = false;
        welldoneScreen.gameObject.SetActive(true);
        wellDoneScore.text = "Your score: " + score;
        lastGameScore = score;
        SaveHighScore();
    }



    [System.Serializable]
    class SaveData
    {
        public int lastGameScore;
    }

    public void SaveHighScore()
    {
        SaveData saveData = new SaveData
        {
            lastGameScore = lastGameScore
        };

        string json = JsonUtility.ToJson(saveData);
        File.WriteAllText(Application.persistentDataPath + "/saveData.json", json);
    }

    public void LoadHighScore()
    {
        string filePath = Application.persistentDataPath + "/saveData.json";

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            SaveData saveData = JsonUtility.FromJson<SaveData>(json);
            lastGameScore = saveData.lastGameScore;
        }
        else
        {
            lastGameScore = 0; // Default high score if the save data doesn't exist
        }
    }

}
