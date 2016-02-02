using UnityEngine;
using System.Collections;

public class ChangeSoundBoxTexture : BaseComponent {
	public GameObject boxOne, boxTwo;

	Vector3 initialPos;

	// Use this for initialization
	void Start () {
		GameManager.DowngradeLevelOne += DownToOne;
		GameManager.UpgradeLevelTwo += UpToTwo;

		initialPos = boxTwo.transform.position;
	}

	void DownToOne() {
		boxOne.SetActive (true);
	}

	void UpToTwo() {
		boxOne.SetActive (false);
	}
}
