using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PracticeDelegatenoparams : MonoBehaviour
{
   public Action noparamsdelegate;
   public Func<int> noparamsdelegatewithreturntype;
   public Func<int,int,int> paramswithreturntype;
   public Func<string,int> stringintreturn;
   
   
   private void Start()
   {
       noparamsdelegate = () => Debug.Log("Name of Object "+ gameObject.name);
       noparamsdelegate();

       noparamsdelegatewithreturntype = () => this.gameObject.name.Length;
       int count = noparamsdelegatewithreturntype();
       Debug.Log("My GameObject Name char count "+count);

       paramswithreturntype = (a,b) => 
       {
           return a+b;
       };
       int count2 = paramswithreturntype(99,99);
       Debug.Log("Delegate with returntype and parameters : "+ count2);

       stringintreturn = (name) => 
       {
        return name.Length;
       };

       int charcount = stringintreturn("Gokulraj");
       Debug.Log("Gokulraj char count "+charcount);



   }

 /*   int getname()
    {
       return this.gameObject.name.Length; 
    }

    int add(int a,int b)
    {
        return a+b;
    }
    */


  
}
