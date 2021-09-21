using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    //Mis variables
    [SerializeField] int num1; 
    [SerializeField] int num2; 
    [SerializeField] int operador;
    int resultado;

    // Start is called before the first frame update
    void Start()
    {
        Calcular(); 
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // Método de saludo
    void Calcular()
    {
        //Si, se puede hacer con un switch, pero nunca se me dieron bien :)
        if (operador == 0)
        {
            resultado = num1 + num2;
        }
        else if (operador == 1)
        {
            resultado = num1 - num2;
        }
        else if (operador == 2)
        {
            resultado = num1 * num2;
        }
        else if (operador == 3)
        {
            resultado = num1 / num2;
        }
        else
        {
            print("Introduce un valor entre 0 y 3, ambos incluidos");
        }
        print(resultado);
    }
}
