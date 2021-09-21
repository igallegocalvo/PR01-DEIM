using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    //Mis variables
    private int n = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
        while (n != 5)
        {

            print("El valor es: " + n + ". Continua!");
            n = Random.Range(0, 1001);

        }

        print("Ok, el valor es 5, pues me paro");


    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
