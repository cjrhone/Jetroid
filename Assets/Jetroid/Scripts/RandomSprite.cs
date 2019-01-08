﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSprite : MonoBehaviour {

	public Sprite[] sprites;
	public int currentSprite = -1;

	// Use this for initialization
	void Start () {

		if(currentSprite == -1) {
			currentSprite = Random.Range (0, sprites.Length);
			// -1 defers to random sprite outside of range
			// 1-4 determines which color sprite to use
		} else if ( currentSprite > sprites.Length) {
			currentSprite = sprites.Length - 1;
		}

		GetComponent<SpriteRenderer>().sprite = sprites[currentSprite];
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
