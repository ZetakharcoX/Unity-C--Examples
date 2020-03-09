using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class games
{
    public string gname;
    public float rating;

    public static string gener;

    static games()
    {
        gener = "Horror";
        Debug.Log("Intialized Once");
        Debug.Log("Game Type : " + gener);
    }

    public games()
    {
        Debug.Log("instance members intialized everytime");
    }
}


public class Staticconstructor : MonoBehaviour
{
   

    void Start()
    {
        games Re7 = new games();
        games wwz = new games();
        games ff = new games();
    }
}
