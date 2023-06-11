using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private Rigidbody2D ballRb;
    public float ballVelocity=0.02f;
    public GameObject player;
    public bool IsPlay; 



    // Start is called before the first frame update
    void Start()
    {

        ballRb = GetComponent<Rigidbody2D>();

       

    }

    // Update is called once per frame
    void Update()
    {

        BallInicialPosition(); 

        if(Input.GetKeyDown(KeyCode.Space) && IsPlay== false)
        {

            IsPlay = true; 
            Vector2 inicialVelocity = new Vector2(1, 1);
            ballRb.AddForce(inicialVelocity * ballVelocity, ForceMode2D.Force);

        }
        
    }

    private void BallInicialPosition ()


    {
        if(IsPlay == false )
        {

            Vector2 playerOffsetPosition = new Vector2(player.transform.position.x, player.transform.position.y + 0.5f);

            gameObject.transform.position = playerOffsetPosition; 

        }



    }
}
