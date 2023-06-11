using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class UiManagerHome : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panelPrincipal;

   
    public GameObject inputTextFieldGO;
    public TMP_InputField textName;
    // Start is called before the first frame update
    private void Awake()
    {
        panelPrincipal.SetActive(true);
        Time.timeScale = 1f;

      
    }

    public void SavePlayerName()
    {

        string playerbasic = textName.text;
        PlayerPrefs.SetString("nombrejugador", playerbasic);
        GameData.instance.DataPlayerName(playerbasic);
        

    }
}
