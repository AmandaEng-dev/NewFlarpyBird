using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    //run thisnfunction from unity itself
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }
}//UI is another Game object but if we want to refernce any of the components u have to add UsingUnityUI to top,
//Use tags when you want to refernce a component when one of the Game object is not in the scene, it has to be running
//A public fucntion can be run through another script as long as you have a refrncd to that script