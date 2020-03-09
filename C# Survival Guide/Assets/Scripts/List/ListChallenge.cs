using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListChallenge : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> Objectsforuse = new List<GameObject>();
    [SerializeField]
    private List<GameObject> Spawners = new List<GameObject>();
   
   
    

    void Start()
    {
       
        
    }

   
    void Update()
    {
        var randompos = new Vector3(Random.Range(-8.31f,8.31f),Random.Range(-4.45f,4.45f),transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var SourceObject = Objectsforuse[Random.Range(0,Objectsforuse.Count)];

            if (Spawners.Count <10)
            {
             Spawners.Add(Instantiate(SourceObject,randompos,Quaternion.identity));
            }

            if (Spawners.Count == 10)
            {
                foreach(var obj in Spawners)
                {
                    var cc = obj.GetComponent<MeshRenderer>();
                    cc.material.color = Color.green;
                }

                Invoke("clearlist",3f);
            }

        }
    }

    void clearlist()
    {
        Spawners.Clear();
    }
}
