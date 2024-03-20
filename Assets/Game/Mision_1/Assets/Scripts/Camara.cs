using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCamar : MonoBehaviour
{
    public float Velocidad = 100f;
    float RotacionX = 0f;

    public Transform Jugador;

    // Start is called before the first frame update
    void Start()
    {
        //Para que el cursor mantenga en pantalla
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * Velocidad * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * Velocidad * Time.deltaTime;
        RotacionX -= MouseY;
        //Para poner limitaciones
        RotacionX = Mathf.Clamp(RotacionX, -90f, 90f);
        float ejeX = 0f;

        if (Input.GetKey(KeyCode.Q))
        {
            ejeX = -1f;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            ejeX = 1f;
        }
        transform.localRotation = Quaternion.Euler(RotacionX, 0f, 0f);
        Jugador.Rotate(Vector3.up * (ejeX + MouseX));

    }


}
