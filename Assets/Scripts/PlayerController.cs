using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject player;
    private Rigidbody2D playerRb;
    public float playerVelocity; 


    // Start is called before the first frame update
    void Start()
    {
        playerRb = player.GetComponent<Rigidbody2D>(); 


    }

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal(); 


        
    }


    private void MoveHorizontal()
    {

        float playerDirection = Input.GetAxis("Horizontal"); 
        Vector2 horizontalForce = new Vector2(player.transform.position.x +playerDirection * Time.deltaTime * playerVelocity, player.transform.position.y);

        player.transform.position = horizontalForce; 
        

    }

}
