using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    //run thisnfunction from unity itself
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        //added scene manger library. now call up scen manger. looking for a file name of the scnen. bc we want the current scence we get active scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        //will trigger when bird crashes into a pipe
        gameOverScreen.SetActive(true);
    }

}//UI is another Game object but if we want to refernce any of the components u have to add UsingUnityUI to top,
//Use tags when you want to refernce a component when one of the Game object is not in the scene, it has to be running
//A public fucntion can be run through another script as long as you have a refrncd to that script