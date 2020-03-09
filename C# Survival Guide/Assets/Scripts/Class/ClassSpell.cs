using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSpell : MonoBehaviour
{
    [SerializeField]
    public int level=1;
    public int exp;
    public spell[] Spells;

    void Start()
    {
      //  magic = new spell("Magic",1,6,0.3f);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // magic.castspell();
           // exp +=magic.expgained;

           foreach (var obj in Spells)
           {
               if (level==obj.levelreq)
               {
                   Debug.Log("" + obj.name + " Casted");
                   exp += obj.expgained;
               }
                              
           }
           switch(exp)
            {
                case 100:
                    Debug.Log("Level 2");
                    break;
                case 200:
                     level = 3;
                    break;
                case 300:
                    level = 4;
                    break;
                default:
                    level = 1;
                    break;
                }

        }

        
        
    }
}
