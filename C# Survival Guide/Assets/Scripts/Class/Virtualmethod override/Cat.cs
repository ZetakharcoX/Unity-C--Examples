using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Cat : pet
{
    
    protected override void Sound()
    {
        Debug.Log("Meow Meow !");
    }
}
