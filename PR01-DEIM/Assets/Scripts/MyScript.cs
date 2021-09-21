using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    //Mis variables
    private int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Contador");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   IEnumerator Contador()
    {
        while (num <= 10)
        {
            yield return new WaitForSeconds(1f);
            print(num);
            num++;
        };
    }
    
}
