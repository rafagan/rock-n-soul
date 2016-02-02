using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	public AudioSource MusicOne, MusicTwo, MusicThree;

	// Use this for initialization
	void Start () {
		StartCoroutine (StartFirstMusic());
	}

	void Update() {

	}

	public void UpgradeMusicToSecondLevel() {
		MusicOne.volume = 0;
		MusicTwo.volume = 100;
	}

	public void UpgradeMusicToThirdLevel() {
		MusicTwo.volume = 0;
		MusicThree.volume = 100;
	}

	public void DowngradeMusicToFirstLevel() {
		MusicTwo.volume = 0;
		MusicOne.volume = 100;
	}
	
	public void DowngradeMusicToSecondLevel() {
		MusicTwo.volume = 100;
		MusicThree.volume = 0;
	}

	IEnumerator StartFirstMusic() {
		yield return new WaitForSeconds(0.0f);
		MusicOne.Play ();
		MusicOne.volume = 100;
		MusicTwo.Play ();
		MusicTwo.volume = 0;
		MusicThree.Play ();
		MusicThree.volume = 0;

		StartCoroutine (EndGame());
	}

	IEnumerator EndGame() {
		yield return new WaitForSeconds (MusicOne.clip.length);
		Application.LoadLevel(0);
	}
}
