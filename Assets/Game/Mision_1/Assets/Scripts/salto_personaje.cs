using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto_personaje : MonoBehaviour
{
    public float velocidadMovimiento = 10f;
    public float fuerzaSalto = 3f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        if (Mathf.Abs(movimientoHorizontal) > 0f)
        {
           
            Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, 0f) * velocidadMovimiento;
            rb.AddForce(movimiento);
        }
        else
        {
            rb.velocity = new Vector3(0f, rb.velocity.y, rb.velocity.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }
    }

    private void Saltar()
    {
      
        if (rb.velocity.y == 0f)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }
}
