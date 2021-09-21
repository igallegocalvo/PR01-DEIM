using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    //Mis variables

    public string miString = "Hola mundo";
    [SerializeField] int miInt = 5;
    [SerializeField] float miFloat = 2f;
    public bool miBool;

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
