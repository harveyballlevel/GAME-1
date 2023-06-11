using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    [SerializeField]

    private bool isHit;
    
    
    
   




    // Start is called before the first frame update
    void Start()
    {
        isHit = false; 
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (isHit == false)
        {

            isHit = true;
           
            

           
            Destroy(gameObject);

        }

       

    }



private void AddPoint()
    {
        GameData.instance.playerScore += 1; 
        


    }

    public void OnDestroy()
    {
        AddPoint();
    }


   
    }

