using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class peuimanager : MonoBehaviour
{
    public Text counts;
    public int diecube;
    
    private void OnEnable()
    {
        Practicaleventcube.cubedie += Diecount;
    }

    public void Diecount()
    {
       diecube++;
       counts.text = "Total Deaths" + diecube;
    }
}
