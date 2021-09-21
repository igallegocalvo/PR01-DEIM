using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    //Mis variables

    private string miString = "Hola mundo";
    private int miInt = 5;
    private float miFloat = 2f;
    private bool miBool;

    // Start is called before the first frame update
    void Start()
    {
        print(miString);
        print(miInt);
        print(miFloat);
        print(miBool);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
