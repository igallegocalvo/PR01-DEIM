using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactividad : MonoBehaviour
{
    //Variable con la posición del jugador
    [SerializeField] Vector3 playerPosition = new Vector3(0f, 0f, 0f);
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerPosition;
    }

    // Update is called once per frame
    void Update()
    {
        

        transform.Translate(Vector3.left * Time.deltaTime * Input.GetAxis("Horizontal") * speed);
    }
}
