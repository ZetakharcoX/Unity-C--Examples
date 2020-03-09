using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printnameslist : MonoBehaviour
{
    [SerializeField]
    private List<string> somenames = new List<string>();
    
    void Start()
    {
        foreach (var obj in somenames)
        {
            Debug.Log(obj);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var removename = somenames[Random.Range(0,somenames.Count)];
            somenames.Remove(removename);

            foreach (var obj in somenames)
            {
                Debug.Log(obj);
            }

            Debug.Log("" +removename+" Name Removed Randomly");
        }
    }

}
