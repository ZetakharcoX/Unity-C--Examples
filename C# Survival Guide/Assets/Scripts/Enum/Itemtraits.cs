using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Itemtraits
{
     public enum itemtype
    {
        None,
        Weapon,
        Powerups        
    }

    public string iname;
    public int id;
    public itemtype Currentitem;

   public void Selecteditem (int i)
   {
        if (i == 0)
       {
           Currentitem = itemtype.None;
           Debug.Log("You Selected a "+Currentitem);
           
       }

       if (i == 1)
       {
           Currentitem = itemtype.Powerups;
           Debug.Log("You Selected a "+Currentitem);
           
       }
        else if (i == 2)
        {
            Currentitem = itemtype.Weapon;
           Debug.Log("You Selected a " + Currentitem);
        }                  
       
   }
  
}
