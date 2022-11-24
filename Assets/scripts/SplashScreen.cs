using System.Collections;
using UnityEngine;

public class SplashScreen : MonoBehaviour {
	Texture2D blackTexture;
	float fadeSpeed = 5.0f;
	float alpha = 1.0f;
	float DelayTime = 3;
	public string WhatScene;
	void Start(){
		alpha = 1.0f;
		blackTexture = new Texture2D (1, 1);
		blackTexture.SetPixel (0, 0, Color.black);
		blackTexture.Apply ();
	}
	void LoadingScene (){
		Application.LoadLevel (WhatScene);
	}
	void update(){
	}
		void OnGUI(){
			if (alpha > -1){
			alpha -= fadeSpeed * Time.deltaTime;  
				GUI.DrawTexture(new Rect (0, 0, Screen.width, Screen.height), blackTexture);
			}
			else{
			Invoke ("LoadingScene", DelayTime);
		}
	}
}
				