using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    private void OnTriggerEnter(Collider obj) {
        if (obj.tag == "Enemigo") Destroy(obj.gameObject);
    }  
}
