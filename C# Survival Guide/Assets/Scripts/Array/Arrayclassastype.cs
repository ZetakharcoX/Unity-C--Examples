using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Items
{
    public int id;
    public string name;
    public int damage;
}

public class Arrayclassastype : MonoBehaviour
{
    [SerializeField] Items[] myitems;

    void Start()
    {
        foreach(var obj in myitems)
        {
            Debug.Log("" + obj.name + " has a  " + obj.damage + "% Damage");
        }

        for(int i= 0 ; i<myitems.Length ; i++)
        {
            Debug.Log("" + myitems[i].name + " has a " + myitems[i].damage + "% Damage" );
        }

        foreach (var obj in myitems)
        {
            if (obj.id == 2)
            {
                Debug.Log("You Selected a " + obj.name );
            }
        }

        for (int i=0; i < myitems.Length ; i++)
        {
            if (myitems[i].id == 3)
                Debug.Log("You selected a " + myitems[i].name);
        }

    }

   
    void Update()
    {
        
    }
}
