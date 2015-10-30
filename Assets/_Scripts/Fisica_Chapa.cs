using UnityEngine;
using System.Collections;

public class Fisica_Chapa : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb.AddForce (Vector3.right * 50f, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
