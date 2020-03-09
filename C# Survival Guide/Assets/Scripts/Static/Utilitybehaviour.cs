using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilitybehaviour : MonoBehaviour
{
    public GameObject Colorchange;
    MeshRenderer Pick;

    void Start()
    {
        Pick = Colorchange.GetComponent<MeshRenderer>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
                UtilityHelper.Createcube();
        }

        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            UtilityHelper.Setposition(this.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            UtilityHelper.Changecolor(Pick);
        }
    }
}
