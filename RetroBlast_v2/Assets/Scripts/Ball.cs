using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Ball : MonoBehaviour
{
   

    public GameManager gameManager;
    public int score;
    public Rigidbody2D ballRb;
    public float speed = 0.5f;
    private bool ballDropped = false;
  


    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        //ballRb.velocity = Vector2.zero; // Set initial velocity to zero
      
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.isGameActive)
        {

            if (!ballDropped)
            {
                DropBall();
                ballDropped = true;
            }
            // Allow the ball to move


        }

      

        if (score == 18)
        {
            gameManager.GameFinished();
        }

    }

    void DropBall()
    {
        Invoke("SetRandomTrajectory", 0.5f);
    }

   public void SetRandomTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = UnityEngine.Random.Range(-0.5f, 0.5f);
        force.y = -1;


        ballRb.AddForce(force.normalized * speed);



    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bottom"))
        {
            gameManager.GameOver();

        }

        if (collision.gameObject.CompareTag("Block"))
        {
            score = score+1;
          gameManager.score = score;
         
        }
    }
  
        
    }

