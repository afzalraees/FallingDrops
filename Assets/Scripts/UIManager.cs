using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject playButton;
    public Transform bg;
    public TextMeshProUGUI finalScore;
    public TextMeshProUGUI scoreTxt;
    public GameObject gameOverScreen, htpScreen, homeScreen, playScreen;
    // Start is called before the first frame update

    private void Start()
    {

    }

    public void PlayGameUI()
    {
        OpenScreen(null);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        scoreTxt.gameObject.SetActive(false);
        GameManager.instance.gameOver(finalScore);
    }

    public void UpdateScore(int score)
    {
        scoreTxt.text = score.ToString();
    }

    public void OpenScreen(GameObject screen)
    {
        gameOverScreen.SetActive(false);
        homeScreen.SetActive(false);
        htpScreen.SetActive(false);
        playScreen.SetActive(false);
        if(screen!=null)
        {
            screen.SetActive(true);
        }        
    }

    public void ResetUI()
    {
        scoreTxt.text = "0";
        scoreTxt.gameObject.SetActive(true);   
    }
}
