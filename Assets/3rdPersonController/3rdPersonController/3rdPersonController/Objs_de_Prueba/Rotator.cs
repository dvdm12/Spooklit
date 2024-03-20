using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	

	void Update () 
	{
		
		transform.Rotate (new Vector3 (0, 20, 0) * Time.deltaTime);

		// 30 30 30  se lee posicion X Y Z
	}
}	