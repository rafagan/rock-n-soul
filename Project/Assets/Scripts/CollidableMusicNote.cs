using UnityEngine;
using System.Collections;

public class CollidableMusicNote : AbstractCollidable
{
    private MusicNoteAttributes _attributes;
	public Vector3 PositionToSpawn;

	public ParticleSystem Particle;

    void Start() {
		_attributes = GetComponent<MusicNoteAttributes>();
	}
	
	// Update is called once per frame
    void Update()
    {
	}

    public override void ExecuteCollisionResult()
    {
		if (_attributes.UseXboxJoystickTriggers)
		if ((Input.GetAxis ("RT LT") > 0.8f && _attributes.JoystickTriggerAngle > 0) || 
			(Input.GetAxis ("RT LT") < -0.8f && _attributes.JoystickTriggerAngle < 0)) {
			Destroy (gameObject);
			ObjectDestroyed();
			return;
		}

        if (!Input.GetButtonDown(_attributes.InputName)) return;

		GameManager.Excitement += _attributes.ScoreValue;
        Destroy(gameObject);
		ObjectDestroyed ();
    }

	void ObjectDestroyed() {
		Instantiate (Particle,PositionToSpawn + new Vector3(0,3,0),Particle.transform.rotation);
		Particle.Play ();
	}
}
