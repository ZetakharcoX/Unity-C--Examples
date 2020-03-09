using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pegamemanager : MonoBehaviour
{
    private void OnEnable() 
    {
        Practicaleventcube.cubedie +=Resetplayer;
    }

    private void Resetplayer()
    {
        Debug.Log("Resetting Player");
    }
}
