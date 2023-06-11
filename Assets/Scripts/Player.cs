using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Player : MonoBehaviour
{


    public GameObject canvasUiManager;  
    public GameObject panelHighScore;

    private UiManager uiManager;

    public bool isDead;

    [SerializeField]
    public int playerlives; 
    

    // Start is called before the first frame update
    void Start()
    {
        playerlives = 1;
        isDead = false;

        uiManager = canvasUiManager.GetComponent<UiManager>();
     
        
    }

    // Update is called once per frame
    void Update()
    {
       if(playerlives <= 0 )
        {

            PlayerDead(); 


        }

    }


    public void PlayerLooseLives()

    {
        playerlives--; 

        Debug.Log("se esta activando "); 

    }

    public void PlayerDead()
    {
        
       
        panelHighScore.SetActive(true); 
        
        isDead = true;
       
       
        uiManager.BestPointsOfTheGame();
        Time.timeScale = 0f;
    }

}
