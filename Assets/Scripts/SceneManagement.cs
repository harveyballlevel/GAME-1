using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update

 

    private void Start()
    {

        
        
       

        
    }










    public void StartGame()
    {
        
       
        SceneManager.LoadScene(1);
       
        Time.timeScale = 1f;
        
    }

    public void BackToMainMenu()
    {

        GameData.instance.playerScore = 0;
        GameData.instance.recordScore = PlayerPrefs.GetInt("highscore");
        Debug.Log(GameData.instance.playerScore + GameData.instance.recordScore); 
        SceneManager.LoadScene(0);
        
        


    }

    

    public void QuitGame()
    {
        Application.Quit();



    }
}