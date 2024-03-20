using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public CharacterController Controlador;

    public float Velocidad = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 mover = transform.right * x + transform.forward * z;
        
        Controlador.Move(mover * Velocidad * Time.deltaTime);
    }
}
