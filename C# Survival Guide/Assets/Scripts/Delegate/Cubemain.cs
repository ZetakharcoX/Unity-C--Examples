using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubemain : MonoBehaviour
{
    
    void Start()
    {
           Delegatemain.Buttonclick +=Turnred;
           Delegatemain.Buttonclick +=Info;
    }

    public void Turnred()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void Info()
    {
        Debug.Log("The Cube Color Changed");
    }

}
