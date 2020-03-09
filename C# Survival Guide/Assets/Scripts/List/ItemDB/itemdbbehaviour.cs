using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemdbbehaviour : MonoBehaviour
{
    [SerializeField]
    private List<itemlist> createitems = new List<itemlist>();

    public void Additems(int getid, Playermain playerone)
    {
        foreach(var item in createitems)
        {
            if (item.id == getid)
            {
                Debug.Log("We Have a Match");
                playerone.Playerinventory[0] = item;
                return;
            }
            else
            {
                Debug.Log("We dont have a match");
            }
        }
    }

    public void Removeitems(int id,Playermain playerone)
    {
        foreach (var obj in createitems)
        {
            if (obj.id == id)
            {
                Debug.Log("Match Found");
                playerone.Playerinventory[0] = null;
            }
        }
    }
    
}
