using UnityEngine;


public class Rotators : MonoBehaviour {

	// Antes de renderizar cada fotograma ...
	void Update () 
	{
		// Gire el objeto del juego al que se adjunta este script en 15 en el eje X,
		// 30 en el eje Y y 45 en el eje Z, multiplicado por deltaTime para hacerlo por segundo
		//en lugar de por fotograma.
		transform.Rotate (new Vector3 (0, 30, 0) * Time.deltaTime);
	}
}	