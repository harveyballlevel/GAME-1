
using System.Collections.Generic;
using UnityEngine;



public class GameData : MonoBehaviour
{
    public static GameData instance;
  
    public int playerScore;
    public int recordScore;
    public string namePlayer; 
    private List<string> participantes =new List<string>();
  
    
    public string highScore;  


  
    private void Awake()
    {

       
        recordScore = PlayerPrefs.GetInt("highscore"); 
       
        if (instance != null && instance != this)
        {
            // Destruir esta instancia
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        
        
        
    }

   

    // Update is called once per frame
    void Update()
    {
         

        RecordScore(); 



    }
    // estto encuentra el nombre escrito en la taquilla principal
  
    




    private void RecordScore()
    {
        if(playerScore>recordScore)
        {

            recordScore = playerScore;
        }
        
        

    }


       

    
    

    public void DataPlayerName(string playerName)
    {
  

        participantes.Add(playerName);

        
        namePlayer = playerName;
        Debug.Log(namePlayer);
        
    }
     
    
   

   


   


}










