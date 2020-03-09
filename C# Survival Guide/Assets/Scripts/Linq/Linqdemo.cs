using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Linqdemo : MonoBehaviour
{
   public string[] somenames = {"mark", "willson","arya","dan","zack","victor","dan","brad","kurl","patrick","mark"};

    void Start()
    {
     /*   foreach (var obj in somenames)
        {
            if (obj == "dan")
                Debug.Log("Found "+obj);
        }
        */
         var getname = somenames.Any(name => name == "brad");
         Debug.Log("Name Found "+getname);

        var getthat = somenames.Contains("kurl");
        Debug.Log("Kurl name found: " + getthat);

        var duplicate = somenames.Distinct();
        foreach(var obj in duplicate)
            Debug.Log("original names:" +obj);

        var largenames = somenames.Where(name => name.Length>5);
        foreach (var obj in largenames)
        {
            Debug.Log("More Than Five Characters: "+obj);
        }




    }

    
    void Update()
    {
        
    }
}
