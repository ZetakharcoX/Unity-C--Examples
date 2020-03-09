using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actionsub : MonoBehaviour
{
   

    private void Start()
    {
       Acitonmain.damrec +=damcalc;
    }

    public void damcalc(int i)
    {
        Debug.Log("Damage taken :"+i);
    }
    
   
}
