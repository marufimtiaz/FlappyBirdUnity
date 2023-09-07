using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleScript : MonoBehaviour
{
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
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3 && bird.birdAlive) 
        {
            logic.addScore();
        }
    }
}
