using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityHelper
{
   

    public static void Createcube()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    public static void Setposition(GameObject obj)
    {
        obj.gameObject.transform.position = new Vector3(0,0,0);
    }

    public static void Changecolor(MeshRenderer tochange)
    {
       tochange.material.color = new Color(Random.value , Random.value, Random.value);
    }
}
