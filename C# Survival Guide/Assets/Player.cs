using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifelse : MonoBehaviour
{
    private int score;
    public int g1,g2,g3,g4,g5,average;
    
    void Start()
    {
        average = ((g1+g2+g3+g4+g5 ) / 5 );
        
        if (average<=100 && average>=90)
        {
            Debug.Log("Grade is A");
        }
        else if (average<90 && average>=80)
            Debug.Log("Grade is B");
        else if (average<80 && average>=70)
            Debug.Log("Grade is C");
        else if (average<70 && average>=60)
            Debug.Log("Grade is D");
        else if (average<60 && average>=50)
            Debug.Log("Grade is E");
        else
            Debug.Log("Failed");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            score+=10;
            Debug.Log("Score is " + score);
        }
    }
}
