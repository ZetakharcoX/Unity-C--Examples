using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdic
{
    public int id;
    public string iname;

    public Playerdic (int i)
    {
        this.id = i;
    }
}

public class Playerdict : MonoBehaviour
{
    Playerdic p1;
    Playerdic p2;
    Playerdic p3;
    Dictionary<int,Playerdic> Mydict = new Dictionary<int, Playerdic>();

    void Start()
    {
     
        p1 = new Playerdic(39);
        p1.iname ="Maxx";
        p2 = new Playerdic(523);
        p2.iname="shon";
        p3 = new Playerdic(65);
        p3.iname = "blow";

        Mydict.Add(p1.id,p1);
        Mydict.Add(p2.id,p2);
        Mydict.Add(p3.id,p3);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var player1 = Mydict[p1.id];
            Debug.Log("Player 1 id is : "+player1.id);

        }
    }

    
}
