using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generador : MonoBehaviour {
	private Rigidbody rb;
	private int fuerza = 10;
	public GameObject caja;
	public Transform salida;
	void Start ()
	{
		rb = GetComponent<Rigidbody> ();

	}
	

	void Update ()
	{
		transform.Translate (Vector3.left * Time.deltaTime * fuerza);

		if (Input.GetKeyDown(KeyCode.Space)) 
		{
			Instantiate (caja, salida.position,salida.rotation);
			transform.Translate(Vector3.up * Time.deltaTime * 120);
			
		}
	}

	void OnTriggerEnter(Collider other) 
	{
		print ("si");
		fuerza = fuerza * -1;
	
	}


}
