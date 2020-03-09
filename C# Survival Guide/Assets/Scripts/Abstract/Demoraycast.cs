using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demoraycast : MonoBehaviour
{
   

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray rayorigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit Hitinfo;

            if (Physics.Raycast(rayorigin,out Hitinfo))
            {
             /*   if (Hitinfo.collider.name== "Playerabs")
                {
                    Hitinfo.collider.GetComponent<Playerabstract>().damage(50);
                }
                else if (Hitinfo.collider.name == "Enemyabs")
                {
                    Hitinfo.collider.GetComponent<Enemyabstractnew>().damage(50);
                }
            */

                IDamagable obj = Hitinfo.collider.GetComponent<IDamagable>();

                if (obj != null)
                {
                    obj.damage(50);
                }
            }
        }
        
    }
}
