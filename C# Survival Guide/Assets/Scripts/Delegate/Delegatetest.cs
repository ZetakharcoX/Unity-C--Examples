using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegatetest : MonoBehaviour
{
  // public delegate void Testdel();
  public delegate void Testdel(Vector3 getpos);
   public static event Testdel Publisherevent;

   

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          /*  if(Publisherevent != null)
                Publisherevent();
            */

            if (Publisherevent != null)
            {
                Vector3 pos = new Vector3(5,2,-8);
                Publisherevent(pos);
            }
        }
    }
}
