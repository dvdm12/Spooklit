using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform cameraTrans;
    void Start()
    {
        
    }

    void Update()
    {
        this.transform.position = cameraTrans.position;
        this.transform.rotation = cameraTrans.rotation;
    }
}
