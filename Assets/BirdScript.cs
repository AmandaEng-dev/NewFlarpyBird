using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;

    

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //every frame the game is checking hey has the  space bar has just been pressed, then make the bird jumo if so. bird is alive statemnt is saying now the bird won't flap if its dead

        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
    //when that collison occurs trigger the Game Over Script
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();

        birdIsAlive = false;
    }
}
