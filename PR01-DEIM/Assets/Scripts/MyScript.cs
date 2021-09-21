using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyScript : MonoBehaviour
{

    //Mis variables
    private int seg;
    private int min;
    private int horas;
    private bool activaReloj;
    [SerializeField] Text miTexto;

    // Start is called before the first frame update
    void Start()
    {
        miTexto.text = "Pulsa barra espaciadora para iniciar";
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) && activaReloj == false)
        {
            StartCoroutine("Reloj");
            activaReloj = true;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && activaReloj == true)
        {
            StopCoroutine("Reloj");
            activaReloj = false;
            miTexto.text = "PAUSE";
        }
    }

   IEnumerator Reloj()
    {
        string relojText;
        
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
            relojText = horas.ToString("D2") + ":" + min.ToString("D2") + ":" + seg.ToString("D2");
            miTexto.text = relojText;
            seg++;
        };
    }
    
}
