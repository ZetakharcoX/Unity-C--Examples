using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    public enum Difficult
    {
        Easy,Normal,Hard,Expert
    }

   public Difficult Select;

    void Start()
    {
      /* if (Select == Difficult.Hard)
        Debug.Log("You Selected a " + Select + " level");
        Debug.Log((Difficult)0);
        Debug.Log((int)Difficult.Expert); */

        switch(Select)
        {
            case Difficult.Easy:
            break ;
            case Difficult.Normal:
                Debug.Log(Select);
                break;
            case Difficult.Hard:
            break;
            case Difficult.Expert:
            break; 

        }
        
    }

    
}
