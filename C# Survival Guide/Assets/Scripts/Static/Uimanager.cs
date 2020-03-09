using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Uimanager : MonoBehaviour
{
    public Text Activeenemies;
 
    void Update()
    {
        updateactiveenemies();
    }

    public void updateactiveenemies()
    {
        Activeenemies.text = "Enemies : " + Enemyspawnmanager.Enemycount;
    }
}
