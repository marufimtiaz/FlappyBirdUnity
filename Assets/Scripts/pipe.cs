using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    //public float pipevelocity = 10;
    public float deadzone = -35;
    public logicScript logic;
    public BirdScript bird;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }
    // Update is called once per frame
    void Update()
    {
        if (bird.birdAlive)
        {
            transform.position = transform.position + (Vector3.left * logic.pipevelocity) * Time.deltaTime;
        }

        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
            Debug.Log("Destroyed");
        }
    }
}
