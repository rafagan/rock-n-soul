using UnityEngine;
using System.Collections;

public class InitAbout : MonoBehaviour {

    public GameObject aboutObj;

    void OnClick()
    {
        if (aboutObj.active)
            aboutObj.SetActive(false);
        else
            aboutObj.SetActive(true);
    }
}
