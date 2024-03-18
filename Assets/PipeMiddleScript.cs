using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        //as sson as a new pipe sapwns, will look for logic tag and find a script and put it in the refernce slot. same thing as dragging and dropping the component in the unity editor
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //will urn when ever an onject hits the trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //now this is talking to the logic script
        logic.addScore();
    }
}
