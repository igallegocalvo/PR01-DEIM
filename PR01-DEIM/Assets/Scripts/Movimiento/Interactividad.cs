using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactividad : MonoBehaviour
{
    //Variable con la posici�n del jugador
    [SerializeField] Vector3 playerPosition = new Vector3(0f, 0f, 0f);
    private float speed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        
    }

    void Movimiento()
    {
        //Maximos y minimos del eje X en funci�n del tama�o del encuadre
        float maxX = 9f;
        float minX = -9f;
        
        //Maximos y minimos del eje Y en funci�n del tama�o del encuadre
        float maxY = 5.7f;
        float minY = -3.7f;
        
        //Posici�n del objeto en X e Y
        float posicionX = transform.position.x;
        float posicionY = transform.position.y;

        //Variables para que el c�digo quede bonito
        float despX = Input.GetAxis("Horizontal");
        float despY = Input.GetAxis("Vertical");


        //Movimiento de la "nave" hacia up, down, left, right
        transform.Translate(Vector3.right * despX * speed * Time.deltaTime);

        transform.Translate(Vector3.up * despY * speed * Time.deltaTime);

        //Limitaci�n de movimiento al encuadre de c�mara
        if (posicionX >= maxX && despX > 0 || posicionX <= minX && despX < 0
            || posicionY >= maxY && despY > 0 || posicionY <= minY && despY < 0)
        {
            speed = 0f;
        }
        else
        {
            speed = 5f;
        }

        //Movimiento de avance y retroceso
        bool avance = Input.GetButton("Fire3");
        bool retroceso = Input.GetButton("Jump");

        //Posici�n del objeto en Z
        float posicionZ = transform.position.z;

        if (avance && posicionZ<=10)
        {
            speed = 5f;
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if ( avance && posicionZ > 10)
        {
            speed = 0f;
        }

        if (retroceso && posicionZ > 0)
        {
            speed = 5f;
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        else if (retroceso && posicionZ <= 0)
        {
            speed = 0f;
        }

        /*Hay un peque�o bug: cuando llega al limite de avance y retroceso, si sigo pulsando el boton de avanzar o retroceder
        el movimiento en X e Y est� bloqueado tambi�n porque la velocidad es 0, tengo que apa�arlo*/
    }
}
