﻿using UnityEngine;
using System.Collections;

public class VideoPlayer : BaseComponent {

	// Use this for initialization
	void Start () {
		MovieTexture movie = renderer.material.mainTexture as MovieTexture;
		movie.Play ();
		movie.loop = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
