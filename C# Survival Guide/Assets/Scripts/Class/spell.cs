using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class spell
{
   public string name;
   public int levelreq;
   public int expgained;
   public float duration;

   public spell()
   {

   }

   public spell(string n, int l, int e, float d)
   {
       this.name = n;
       this.levelreq = l;
       this.expgained = e;
       this.duration = d;
   }

   public void castspell()
   {
       Debug.Log("Spell Casted");
   }
   
}
