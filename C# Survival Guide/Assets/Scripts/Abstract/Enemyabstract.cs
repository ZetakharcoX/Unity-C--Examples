using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class Enemyabstract : MonoBehaviour
{
    public int speed;
    public int damage;
    public int expgain;

    public abstract void Attack();
    public virtual void Die()
    {

    }

}

public class kurl : Enemyabstract
{
    public override void Attack()
    {

    }

    public override void Die()
    {
        
    }
    
}


