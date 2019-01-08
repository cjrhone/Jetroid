using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour {

	private SpriteRenderer renderer2D;

	private Color start;

	private Color end;

	private float t = 0f;

	// Use this for initialization
	void Start () {

		renderer2D = GetComponent<SpriteRenderer> ();
		start = renderer2D.color;
		end = new Color(start.r, start.g, start.b, 0f);
		// regular RGB colors, but ends with 0 Alpha
		
	}
	
	// Update is called once per frame
	void Update () {

		t += Time.deltaTime;
		renderer2D.material.color = Color.Lerp(start, end, t/2);
		// change from our start position to end position
		// Lerp interpolates between 2 valsues over a set amount of time
		// Lerp(firstValue, secondValue, timeAmount)

		if (renderer2D.material.color.a <- 0f) {
			Destroy(gameObject);
			//when alpha becomes 0, destory debris 
		}
		
	}
}
