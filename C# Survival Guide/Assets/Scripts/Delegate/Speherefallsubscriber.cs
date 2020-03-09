using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speherefallsubscriber : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Delegatemain.Buttonclick += Clickfall;
    }

    public void Clickfall()
    {
        GetComponent<Rigidbody>().useGravity = true;
    }
    
}
