using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; 




[System.Serializable]
public class SaveData 
{
    public int playerScore;
    public string playerName; 
    


    public void Save ()
    {
        SaveData data = new SaveData();
        data.playerName = playerName;
        data.playerScore = playerScore;

        string json = JsonUtility.ToJson(data);


        File.WriteAllText(Application.persistentDataPath + "/datagame.json", json); 





    }
    public void Load()
    {

        string path = Application.persistentDataPath + "/datagame.json"; 

        if(File.Exists(path) )
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            data.playerName = playerName; 
            data.playerScore = playerScore;



        }

        



    }


    
}
