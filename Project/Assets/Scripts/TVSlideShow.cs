using UnityEngine;
using System.Collections;

public class TVSlideShow : BaseComponent {

	public Material[] Slides;
	public float SlideTime = 2.0f;

	private int _currentSlide = 0;
	private GameObject _childRenderer;

	// Use this for initialization
	void Start () {
		_childRenderer = gameObject.transform.GetChild(0).gameObject;
		StartCoroutine (SlideShow());
	}

	IEnumerator SlideShow() {
		_childRenderer.renderer.material = Slides[_currentSlide];
		yield return new WaitForSeconds (SlideTime);
		_currentSlide = (_currentSlide + 1) % Slides.Length;
		StartCoroutine (SlideShow());
	}
}
