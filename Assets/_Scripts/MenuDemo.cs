﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuDemo : MonoBehaviour 
{

	public Button boton;

	// Use this for initialization
	void Start () 
	{
		boton = boton.GetComponent<Button> ();
	}
	
	// Llama al Level 1
	public void IniciarAplicacion () 
	{
		Application.LoadLevel (2);
	}
}
