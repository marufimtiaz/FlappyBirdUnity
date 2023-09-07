using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logicScript : MonoBehaviour
{
    public int playerScore;
    public int ScoreToAdd = 1;
    public float pipevelocity = 10;
    public float time = 0;
    public Text scoreText;
    public GameObject GameOver;
    public AudioSource blip;
    public AudioSource click;
    

    [ContextMenu("Increase Score")]

    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 5)
        {
            pipevelocity += 1;
            time = 0;
        }

    }
    public void addScore()
    {
        playerScore+=ScoreToAdd;
        scoreText.text=playerScore.ToString(); 
        blip.Play();
    }

    public void gameOverfn()
    {
        GameOver.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        click.Play();
    }
    public void QuitGame()
    {
        Application.Quit();
        click.Play();
    }
}
