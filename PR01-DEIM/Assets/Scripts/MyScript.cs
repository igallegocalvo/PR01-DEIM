using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    //Mis variables
    [SerializeField] string nombre = "personita an�nima";
    
    // Start is called before the first frame update
    void Start()
    {
        Saludo(nombre);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // M�todo de saludo
    void Saludo(string name)
    {
        print ("Hola " + name);
    }
}
