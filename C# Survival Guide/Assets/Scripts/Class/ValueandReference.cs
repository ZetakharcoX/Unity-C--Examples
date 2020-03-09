using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct itemstruct                            //value type
{
    public string sname;
    public int sid;

    public itemstruct(string ssname, int ssid )
    {
        this.sname = ssname;
        this.sid = ssid;
    }

}

public class itemclass                              //reference type
{
    public string iname;
    public int cid;

    public itemclass(string name, int id)
    {
        this.iname = name;
        this.cid  = id;
    }
}



public class ValueandReference : MonoBehaviour
{
    itemclass itemone = new itemclass("apple",1);
    itemstruct itemtwo;

    void Start()
    {
        itemtwo.sname = "Orange";
        itemtwo.sid = 2;
        Debug.Log("reference type itemclass instance member name : " +itemone.iname);
        referencecheck(itemone);
        Debug.Log("reference type itemclass instance member name : " +itemone.iname);

        Debug.Log("value type struct class instance member name : " + itemtwo.sname);
        valuecheck(itemtwo);
        Debug.Log("value type struct class instance member name : " + itemtwo.sname);





        
    }

    void referencecheck(itemclass remodify)
    {
        remodify.iname = "Green apple";
    }

    void valuecheck (itemstruct remodify)
    {
        remodify.sname = "Green Orange";
    }

    
}
