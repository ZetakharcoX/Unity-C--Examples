using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public enum Enemystate
    {
        ideal,
        patroling,
        chasing,
        attacking,    
    }
    
    public Enemystate Currentstate;

    void Start()
    {
        
    }

    
    void Update()
    {
        switch (Currentstate)
        {
            case Enemystate.ideal:
                Debug.Log("Enemy is Ideal");
                break;
            case Enemystate.patroling:
                Debug.Log("Enemy is Patroling");
                break;
            case Enemystate.chasing:
                Debug.Log("Enemy is chasing");
                break;
            case Enemystate.attacking:
                Debug.Log("Enemy is Attacking");
                break;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Currentstate = Enemystate.attacking;
        }
    }
}
