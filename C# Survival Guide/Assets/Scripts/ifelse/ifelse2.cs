using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifelse2 : MonoBehaviour
{
    public GameObject cube;
    Renderer cubedub;
    [SerializeField] private int score = 0;
    public bool hasprint;

    void Start()
    {
        cubedub = cube.GetComponent<Renderer>();
        cubedub.material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score= score + (Random.Range(1,10));

            if (score==50 && hasprint==false)
            {
                cubedub.material.color = Color.green;
                Debug.Log("You Turn The Cube COLOR");
                hasprint = true;
            }
        }

    }
}
