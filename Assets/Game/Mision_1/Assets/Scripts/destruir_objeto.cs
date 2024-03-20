using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir_objeto : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}

