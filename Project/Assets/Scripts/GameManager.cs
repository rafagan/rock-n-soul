using UnityEngine;
using System.Collections;
using System;

public class GameManager : MonoBehaviour
{
    private int _playerPoints = 0;
	private float _excitement = 0.0f;

	public float GameVelocity = 30.0f;
	public int TotalExcitement1 = 10, TotalExcitement2 = 20, TotalExcitement3 = 30; 
	public int ExcitementLevel = 1;

	public Action DowngradeLevelOne, UpgradeLevelTwo;

    public int PlayerPoints
    {
        get { return _playerPoints; }
        set { _playerPoints = value; }
    }

	public float Excitement
	{
		get { return _excitement; }
		set { 
			_excitement = value;
			if(_excitement < 0) _excitement = 0;
			else if(_excitement > TotalExcitement3) _excitement = TotalExcitement3;
		}
	}
}
