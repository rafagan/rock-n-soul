using UnityEngine;
using System.Collections;

public class ChangeLevel : BaseComponent {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Downgrade para level 1
		if (GameManager.Excitement < GameManager.TotalExcitement1 && GameManager.ExcitementLevel == 2) {
			GameManager.ExcitementLevel = 1;
			MusicManager.DowngradeMusicToFirstLevel();
			SceneManager.DowngradeSceneToFirstLevel();
			if(GameManager.DowngradeLevelOne != null) GameManager.DowngradeLevelOne();
		} else if(GameManager.Excitement > GameManager.TotalExcitement1 && GameManager.ExcitementLevel == 1) { //Upgrade para level 2
			GameManager.ExcitementLevel = 2;
			MusicManager.UpgradeMusicToSecondLevel ();
			SceneManager.UpgradeSceneToSecondLevel ();
			if(GameManager.UpgradeLevelTwo != null) GameManager.UpgradeLevelTwo();
		} else if(GameManager.Excitement > GameManager.TotalExcitement2 && GameManager.ExcitementLevel == 2) { // Upgrade para level 3
			GameManager.ExcitementLevel = 2;
			MusicManager.UpgradeMusicToThirdLevel ();
			SceneManager.UpgradeSceneToThirdLevel ();
		} else if(GameManager.Excitement < GameManager.TotalExcitement2 && GameManager.ExcitementLevel == 2) { // Downgrade para level 2
			GameManager.ExcitementLevel = 2;
			MusicManager.DowngradeMusicToSecondLevel ();
			SceneManager.DowngradeSceneToSecondLevel ();
		}
	}
}
