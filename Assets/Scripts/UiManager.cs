using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro; 
public class UiManager : MonoBehaviour



{

    [SerializeField]
    private GameObject livesGo;

    [SerializeField]
    private GameObject nameGo;

    [SerializeField]
    private GameObject pointsGo;

    public GameObject bestPointsGo; 
    public GameObject highScoreGo;

    public GameObject playerListGo;
    public GameObject panelHighScore;

    private TextMeshProUGUI bestPointText; 
    private TextMeshProUGUI livesText;
    private TextMeshProUGUI nameText;
    private TextMeshProUGUI pointsText;
    private TextMeshProUGUI highScoreText; 
   


    public GameObject player;
    public GameObject boxes;


    private int playerScore;
    private int recordScore; 
    void Start()
    {


        panelHighScore.SetActive(false);


        bestPointText = bestPointsGo.GetComponent<TextMeshProUGUI>(); 
        livesText = livesGo.GetComponent<TextMeshProUGUI>();
        nameText = nameGo.GetComponent<TextMeshProUGUI>();
        pointsText = pointsGo.GetComponent<TextMeshProUGUI>();
        highScoreText = highScoreGo.GetComponent<TextMeshProUGUI>();
        nameText.text = PlayerPrefs.GetString("nombrejugador");
        playerScore = GameData.instance.playerScore;
        recordScore = GameData.instance.recordScore; 


    }

    

    // Update is called once per frame
    void Update()
    {
       
        RecordPoints();
        ReloadPoints();
        ReloadLivesText(); 
    }
    public void RecordPoints()

    {

        recordScore = GameData.instance.recordScore;
        highScoreText.text = "HighScore" +  recordScore.ToString();

    }
    public void ReloadLivesText ()
    {
        livesText.text = player.GetComponent<Player>().playerlives.ToString();


    }

    public void  ReloadPoints()
    {
        playerScore = GameData.instance.playerScore; 
        pointsText.text = playerScore.ToString(); 


    }
    
    public void BestPointsOfTheGame()

    {

        string finalScore;
        int highscore = PlayerPrefs.GetInt("highscore"); 
         if (highscore < playerScore)
        {

            PlayerPrefs.SetInt("highscore", playerScore);
            finalScore = PlayerPrefs.GetInt("highscore").ToString();
            bestPointText.text = finalScore; 
        }
        else
        {
            finalScore = PlayerPrefs.GetInt("highscore").ToString();
            bestPointText.text = finalScore; 


        }
       

    }

        
        



    }
  

