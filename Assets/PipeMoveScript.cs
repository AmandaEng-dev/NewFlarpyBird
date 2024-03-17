using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    //defualt value
    public float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time.*deltaTime makes it so not happening depending on FPS on machine. ensures that
        //the multiplciation happens the same, no matter the frame rate
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

    }
}
