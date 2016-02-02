using UnityEngine;
using System.Collections;

public class CloseAbout : MonoBehaviour {

    public GameObject AboutObj;

	// Use this for initialization
    void OnClick()
    {
        AboutObj.SetActive(false);
    }
}
