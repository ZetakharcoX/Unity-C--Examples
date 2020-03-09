using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemdbdictnary : MonoBehaviour
{
    public List<item> myitems = new List<item>();
    public Dictionary<int,item> ItemDict = new Dictionary<int, item>();

    private void Start()
    {
        item Fsword = new item();
        Fsword.name = "Forged Sword";
        Fsword.id =0;

        item Marrow = new item();
        Marrow.name = "Mighty Arrow";
        Marrow.id = 1;

        item Sapple = new item();
        Sapple.name = "Silver Apple";
        Sapple.id = 2;

        ItemDict.Add(0,Fsword);
        ItemDict.Add(1,Marrow);
        ItemDict.Add(2,Sapple);

        foreach (KeyValuePair<int, item> obj in ItemDict)
        {
            Debug.Log("The key is " + obj.Key);
            Debug.Log("The value is " + obj.Value.name);   
        }

        foreach (var key in ItemDict.Keys)
        {
            Debug.Log("Key" + key);
        }

        foreach (item obj in ItemDict.Values)
        {
            Debug.Log("Values are "+obj.name);
        }

        if (ItemDict.ContainsKey(1))
        {
            Debug.Log("The Key Exist");
        }

        


      /*  ItemDict.Add(0,Fsword);

        var Dictone = ItemDict[0];
        Debug.Log(Dictone.name); */
    }

}
