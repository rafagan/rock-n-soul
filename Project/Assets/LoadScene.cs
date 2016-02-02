using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

    public string scene;

    void OnClick()
    {
        Application.LoadLevel(scene);
    }
}
