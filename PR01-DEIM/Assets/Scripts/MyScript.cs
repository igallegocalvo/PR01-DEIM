using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    //Mis variables

    private string saludo = "Hola ";
    [SerializeField] string nombre = "personita anónima";
    public int num1 = 5;
    public int num2 = 2;

    // Start is called before the first frame update
    void Start()
    {
        print(saludo + nombre + ", el resultado de multiplicar " + num1 + " y " + num2 +" es:");
        print(num1 * num2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
