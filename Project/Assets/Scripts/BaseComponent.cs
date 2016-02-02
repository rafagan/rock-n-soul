using UnityEngine;
using System.Collections;

public class BaseComponent : MonoBehaviour
{
	[HideInInspector]
    public GameManager GameManager;
	[HideInInspector]
    public SceneManager SceneManager;
	[HideInInspector]
    public MusicManager MusicManager;

    void Awake()
    {
        var manager = GameObject.Find("_Managers");
        GameManager = manager.GetComponent<GameManager>();
        SceneManager = manager.GetComponent<SceneManager>();
        MusicManager = manager.GetComponent<MusicManager>();
    }
}
