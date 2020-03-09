using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegatetestcub : MonoBehaviour
{
    
    void Start()
    {
        Delegatetest.Publisherevent +=changepos;
    }

  /*  public void changepos()
    {
        transform.position = new Vector3(5,2,transform.position.z);
    }
    */

    public void changepos(Vector3 newpos)
    {
        transform.position = newpos;
    }

}
