using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class help : MonoBehaviour {
	public GameObject Panelhelp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void buttonhelp(){
		Panelhelp.SetActive (true);
	}
	public void buttonclose(){
		Panelhelp.SetActive (false);
	}
}
