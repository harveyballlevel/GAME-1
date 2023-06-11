using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    // Start is called before the first frame update

    public DontDestroyOnLoad instance;



    private void Awake()
    {
        // Verificar si ya existe una instancia de GameData
        if (instance != null && instance != this)
        {
            // Destruir esta instancia
            Destroy(gameObject);
            return;
        }

        // Establecer esta instancia como la instancia activa
        instance = this;

        // No destruir GameData al cambiar de escena
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
       
        

       
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
