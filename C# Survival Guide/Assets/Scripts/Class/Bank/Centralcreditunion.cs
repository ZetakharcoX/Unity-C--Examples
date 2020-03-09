using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Centralcreditunion : Bank
{
    public int availablecasetolend;

    public void approvelending()
    {
        Debug.Log("Your loan approved");
        
    }
    
}
