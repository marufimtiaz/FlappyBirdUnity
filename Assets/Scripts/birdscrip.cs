using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public AudioSource fall;
    public AudioSource bg;
    public float BirdVelocity = 13;
    public float V;
    public float clickTime;
    public logicScript logic;
    public bool birdAlive = true;
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && birdAlive)
        {
            clickTime += 10 * Time.deltaTime;
            V = BirdVelocity + clickTime;
            myRigidBody.velocity = Vector2.up * V;
        }
        else
        {
            clickTime = 0;
        }
        if (Input.GetMouseButton(1) && birdAlive)
        {
            myRigidBody.velocity = myRigidBody.velocity + Vector2.down/5;
        }

        if (time >= 5)
        {
            BirdVelocity += 1;
            myRigidBody.gravityScale += 0.1F;
            time = 0;
        }
        time = time + Time.deltaTime;

        if (transform.position.y < -15.25 && birdAlive)
        {
            logic.gameOverfn();
            birdAlive = false;
            fall.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (birdAlive)
        {
            logic.gameOverfn();
            birdAlive = false;
            fall.Play();
            bg.Stop();
        }
    }
}
