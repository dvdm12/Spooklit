using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenerVida : MonoBehaviour
{
   private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            Destroy(gameObject);
        }
    }
}
