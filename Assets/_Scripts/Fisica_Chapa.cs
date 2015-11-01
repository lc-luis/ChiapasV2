using UnityEngine;
using System.Collections;

public class Fisica_Chapa : MonoBehaviour {

	//public Rigidbody rb;
	public int velocidad = 10;

	// Use this for initialization
	void Start () {
		//rb.AddForce (Vector3.right * 50f, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {

	}

	//Fuerzas continua hacia arriba, tiene en cuenta gravedad y masa del objeto
	void FixedUpdate ()
	{
		//GetComponent<Rigidbody> ().AddForce (new Vector3 (0, velocidad, 0), ForceMode.Force);
		//GetComponent<Rigidbody> ().AddTorque (Vector3.up, ForceMode.Impulse);
	}


}
