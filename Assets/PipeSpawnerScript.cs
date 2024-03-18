using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    //this is a Prefab
    public GameObject pipe;
    //how many seconds between spawns
    public float spawnRate = 2;

    //wont be changing int he editor or anywhere else
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPoint();
            timer = 0;
        }
        //every frame asks if the timer is less than the spawn rate. If it is, then count the timer up, if its not, thne spawn a pipe and spawn a pipe again

       
    }

    void spawnPoint()
    {

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation);
    }
    
}
