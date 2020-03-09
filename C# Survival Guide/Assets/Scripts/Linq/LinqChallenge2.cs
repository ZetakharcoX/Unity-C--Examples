using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[System.Serializable]
public class Linqitem
{
    public string name;
    public int id;
    public int buff;
}

public class LinqChallenge2 : MonoBehaviour
{
   public List<Linqitem> myobjects; 

    void Start()
    {
        var yes = myobjects.Contains(myobjects[3]);
        Debug.Log("Item 3 Exist ? " +yes);

       var buffstatus = myobjects.Where(getb => getb.buff>10);
       foreach (var obj in buffstatus)
       {
           Debug.Log("big buff names : "+obj.name);
       }

      var Average =  myobjects.Average(getb => getb.buff);
      Debug.Log("Averge of buff is: "+Average);


    }

    
    void Update()
    {
        
    }
}
