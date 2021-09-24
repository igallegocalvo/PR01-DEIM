using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactividad : MonoBehaviour
{
    //Variable con la posición del jugador
    [SerializeField] Vector3 playerPosition = new Vector3(0f, 0f, 0f);
    public float speed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerPosition;
    }

    // Update is called once per frame
    void Update()
    {

        float despX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.right * despX * Time.deltaTime);

        float despY = Input.GetAxis("Vertical") * speed;
        transform.Translate(Vector3.up * despY * Time.deltaTime);

        float maxX = 9f;
        float minX = -9f;
        float posicionX = transform.position.x;

        float maxY = 5.7f;
        float minY = -3.7f;
        float posicionY = transform.position.y;

        //Limitación de movimiento al encuadre de cámara
        if (posicionX >= maxX && Input.GetAxis("Horizontal") > 0 || posicionX <= minX && Input.GetAxis("Horizontal") < 0
            || posicionY >= maxY && Input.GetAxis("Vertical") > 0 || posicionY <= minY && Input.GetAxis("Vertical") < 0)
        {
            speed = 0f;
        }
        else
        {
            speed = 5f;
        }
    }
}
