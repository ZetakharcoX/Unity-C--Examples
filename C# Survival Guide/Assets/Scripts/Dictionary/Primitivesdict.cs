using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Primitivesdict : MonoBehaviour
{
    public Dictionary<string,int> persondict = new Dictionary<string, int>();
    public Dictionary<int,string> books = new Dictionary<int, string>();
    
    
    void Start()
    {
        persondict.Add("Boris",27);

        int first = persondict["Boris"];
        Debug.Log("name is "+ first);
    
        books.Add(1,"General Guide for gamedevlopment with unity");
        books.Add(2,"Be Sharp with Csharp : A Practical Guide");
        Debug.Log(books[1]);

        foreach(int obj in books.Keys)
        {
            Debug.Log(obj);
        }
        

    }

    
    void Update()
    {
        
    }
}
