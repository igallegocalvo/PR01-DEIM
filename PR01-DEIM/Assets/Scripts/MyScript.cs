using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{

    //Mis variables
    private int seg;
    private int min;
    private int horas;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Reloj");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   IEnumerator Reloj()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            if (seg == 60)
            {
                seg = 0;
                min++;
            }
            if (min == 60)
            {
                min = 0;
                horas++;
            }
            print(horas.ToString("D2") + ":" + min.ToString("D2") + ":" + seg.ToString("D2"));
            seg++;
        };
    }
    
}
