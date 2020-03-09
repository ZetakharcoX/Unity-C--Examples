using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerabstract : MonoBehaviour, IDamagable
{
    public int health { get; set; }

    public void damage(int damagetaken)
    {
        health -= damagetaken;
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
