using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borders : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject playerGo;
   
    float maxRightPosition = 9f;
    float maxLeftPosition = -9f ;
    float maxLoosePostion = -6f;
    public Ball ball;
    [SerializeField]
    private GameObject uIManager; 


    void Start()
    {

        ball.ballVelocity = 0.02f;
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();
        
    }

    // Update is called once per frame
    void Update()
    {

        LooseGame(); 
        PlayerBorders(); 
    }


    private void PlayerBorders()
    {

        float playerPosX = playerGo.transform.position.x;
        Vector2 leftPosition = new Vector2(maxLeftPosition,playerGo.transform.position.y);
        Vector2 rightPosition = new Vector2(maxRightPosition, playerGo.transform.position.y);


        if (playerPosX <= maxLeftPosition )
        {

            playerGo.transform.position = leftPosition; 

        }
        if(playerPosX >= maxRightPosition)

        {
            playerGo.transform.position = rightPosition; 


        }

    }

    private void LooseGame()

    {

        float ballPosY = ball.transform.position.y;

        if( ballPosY <= maxLoosePostion && ball.IsPlay== true)
        {
            playerGo.GetComponent<Player>().PlayerLooseLives();

            uIManager.GetComponent<UiManager>().ReloadLivesText(); 

            ball.IsPlay = false; 
            
           
            
        }
       
    }


}
