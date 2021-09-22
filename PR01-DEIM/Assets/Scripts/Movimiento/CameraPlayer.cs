using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    //Asociar esta variable al empty del jugador
    [SerializeField] Transform playerPosition;
    //En Unity tendremos que arrastrar el objeto al que queramos seguir al campo que se crea en el inspector

    //Variables para el movimiento de cámara
    [SerializeField] float distanciaJugador = 4f;
    [SerializeField] float alturaCamamara = 1.5f;

    //Vector3 con la posición de la cámara
    Vector3 camaraPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerPosition);

        float newPosY = playerPosition.position.y + alturaCamamara;
        float newPosZ = playerPosition.position.z - distanciaJugador;

        camaraPosition = new Vector3(0f, newPosY , newPosZ);
        transform.position = camaraPosition;
    }
}
