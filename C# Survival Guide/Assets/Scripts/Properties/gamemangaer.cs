using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemangaer : MonoBehaviour
{
    private bool Gamestatus;

    public bool gamestatus
    {
        get
        {
            return Gamestatus;
        }

        set
        {
            if (value==true)
            {
                Debug.Log("Game Over Asshole");
            }
            Gamestatus = value;
        }
    }
    
    void Start()
    {
        
        Gamestatus = false;
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gamestatus = true;
        }
    }
}
