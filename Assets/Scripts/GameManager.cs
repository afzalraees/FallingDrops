using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIManager uiManager;

    public GameObject classicGame;
    public GameObject colorGame;
    public DropManager classicDrops;
    public DropManager colorDrops;

    public int score;

    public bool isClassic;

    public static GameManager instance;

    public bool isGameOver;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
            Destroy(this);
    }
    public void StartClassicGame()
    {
        isClassic = true;
        uiManager.OpenScreen(null);
        classicGame.SetActive(true);
    }

    public void StartColorGame()
    {
        isClassic = false;
        uiManager.OpenScreen(null);
        colorGame.SetActive(true);
    }

    public void gameOver(TextMeshProUGUI finalScore)
    {
        isGameOver = true;
        if (isClassic)
        {
            classicGame.SetActive(false);
        }
        else
            colorGame.SetActive(false);
        
        finalScore.text = score.ToString();
    }

    public void RestartGame()
    {
        if(isClassic)
        {
            classicGame.SetActive(true);
            classicDrops.Resetdrops();
        }
        else
        {
            colorGame.SetActive(true);
            colorDrops.Resetdrops();
        }
        
        score = 0;
        uiManager.OpenScreen(null);
        uiManager.ResetUI();
    }

    public void AddScore()
    {
        score++;
        uiManager.UpdateScore(score);
    }
}
