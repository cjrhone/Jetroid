﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToContinue : MonoBehaviour {

	public string scene;
	public bool loadLock;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0) && !loadLock) {
			//GetMouseDown(0) is left click
			LoadScene();
		}
		
	}

	void LoadScene(){
		loadLock = true;
		SceneManager.LoadScene(scene);
	}
}
