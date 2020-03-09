using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegatemain : MonoBehaviour
{
    public delegate void Actionclick();
    public static event Actionclick Buttonclick;
    
    public void Onclick()
    {
        if (Buttonclick !=null)
            Buttonclick();
    }
    
}
