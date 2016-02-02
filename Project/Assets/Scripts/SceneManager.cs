using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public GameObject[] FirstSceneElementsToShow;
	public GameObject[] SecondSceneElementsToShow;
	public GameObject[] ThirdSceneElementsToShow;

	// Use this for initialization
	void Start () {
		DowngradeSceneToFirstLevel ();
	}
	
	public void UpgradeSceneToSecondLevel() {
		foreach(GameObject gm in SecondSceneElementsToShow) {
			gm.SetActive(true);
		}

		foreach(GameObject gm in FirstSceneElementsToShow) {
			gm.SetActive(false);
		}
	}
	
	public void UpgradeSceneToThirdLevel() {
		foreach(GameObject gm in ThirdSceneElementsToShow) {
			gm.SetActive(true);
		}
	}

	public void DowngradeSceneToFirstLevel() {
		foreach(GameObject gm in SecondSceneElementsToShow) {
			gm.SetActive(false);
		}

		foreach(GameObject gm in ThirdSceneElementsToShow) {
			gm.SetActive(false);
		}

		foreach(GameObject gm in FirstSceneElementsToShow) {
			gm.SetActive(true);
		}
	}
	
	public void DowngradeSceneToSecondLevel() {
		foreach(GameObject gm in ThirdSceneElementsToShow) {
			gm.SetActive(false);
		}
	}
}
