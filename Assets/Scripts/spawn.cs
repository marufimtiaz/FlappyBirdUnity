using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject pipe;
    public logicScript logic;
    public BirdScript bird;
    public float spawnDelay = 0;
    public float timer = 0;
    public float hightOffset = 9;
    // Start is called before the first frame update
    void Start()
    {
        spawnf();   

    }

    // Update is called once per frame
    void Update()
    {
        spawnDelay = 20 / logic.pipevelocity;
        if (bird.birdAlive)
        {
            if(timer < spawnDelay)
            {
                timer = timer +Time.deltaTime;
            }
            else
            {
                spawnf();
                timer = 0;
            }
        }
    }
    void spawnf()
    {
        float highest = transform.position.y + hightOffset;
        float lowest = transform.position.y - hightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);

    }

    
}
