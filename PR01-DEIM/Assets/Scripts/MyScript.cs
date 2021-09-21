using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    //Mis variables
    private int numWhile = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        while (numWhile <= 10)
        {

            if (numWhile < 5)
            {
                print(numWhile + " es menor que 5");
            }
            else if (numWhile == 5) 
            {
                print(numWhile);
            }                            
            else //if (numWhile >5)
            {
                print(numWhile + " es mayor que 5");
            };

            numWhile++;
        };
        
            
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
