using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    //Mis variables
    private int numWhile = 0;
    private int numFor;

    // Start is called before the first frame update
    void Start()
    {
        while (numWhile < 10)
        {
            numWhile++;
            print("El número actual del bucle while es: " + numWhile);
        };
        for (numFor = 10; numFor >= 0; numFor--)
        {
            print("El resultado del bucle for es: " + numFor);
        };
            
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
