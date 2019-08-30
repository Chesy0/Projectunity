using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calcul : MonoBehaviour
{
    int a = 5;
    int b = 6;
    float c;
    int e;
    float f;
    bool l=true ;
    bool m = false;

    int r = 4;
    int s = 5;
    // Use this for initialization
    void Start()
    {

        c = a + b;
        e = a * b;
        f = (float)a / b;
        Debug.Log(c);
        Debug.Log(e);
        Debug.Log(f);


        comparison(r, s);
        operateur(a, b);    }


     public void comparison(int r,int s )
    {
        if (r > s)
        {
            
            Debug.Log(l);
        }
        else
        {
            Debug.Log(m);
        }
    }
     public void operateur ( int a , int b)
    {
        if (a>0 && b > 0)
        {
            Debug.Log("a et b deux nombres positives");
        }
        else
        {
            Debug.Log("a et b deux nombres negatives");
        }
    }
        
    // Update is called once per frame
    void Update()
    {

    }

}

