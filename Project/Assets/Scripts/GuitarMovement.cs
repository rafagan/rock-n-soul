using UnityEngine;
using System.Collections;

public class GuitarMovement : BaseComponent
{	
	void Update () {
		transform.Translate (new Vector3 (0, 0, GameManager.GameVelocity) * Time.deltaTime);
	}
}
