using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuPrincipal : MonoBehaviour 
{

	public Button boton;
	public Button botonDemo;

	// Use this for initialization
	void Start () 
	{
		boton = boton.GetComponent<Button> ();
		botonDemo = botonDemo.GetComponent<Button> ();
	}
	
	// Llama al Level 1
	public void IniciarAplicacion () 
	{
		Application.LoadLevel (1);
	}
	// Llama al Level DEMO
	public void IniciarDemo () 
	{
		Application.LoadLevel (2);
	}
}
