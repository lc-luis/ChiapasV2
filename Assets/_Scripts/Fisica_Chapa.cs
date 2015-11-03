using UnityEngine;
using System.Collections;

public class Fisica_Chapa : MonoBehaviour {

	public Color defaultColor;
	public Color selectedColor;
	private Material mat;



	void Start()
	{
		mat = GetComponent<Renderer>().material;
	}

	void onTouchDown()
	{
		mat.color = selectedColor;
	}

	void onTouchUp()
	{
		mat.color = defaultColor;
		GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 500, 0), ForceMode.Force);
	}

	void onTouchStay()
	{
		mat.color = selectedColor;
	}

	void onTouchExit()
	{
		mat.color = defaultColor;
	}
}
