using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegatedemo : MonoBehaviour
{
    public delegate void timestat(float newnum);                //delgate signature
    timestat timerem;
    public delegate void playerstat(int summa);
    playerstat p1;
    
    void Start()
    {
        timerem = timehave;
        timerem(10);
        p1+=Score;
        p1+=Lives;
        //p1-=Lives;
        p1(20);
        
        
    }

   
    void Update()
    {
        
    }

    public void timehave (float t)
    {
        Debug.Log("Time Remaining  "+t);
    }

    public void Score(int s)
    {
        Debug.Log("Total Score "+s);
    }

    public void Lives(int l)
    {
        Debug.Log("Life Remaining " + l);
    }
}
