using UnityEngine;
using System.Collections;

public class InputScoreBox : BaseComponent {

    void OnTriggerStay2D(Collider2D collision)
    {
        var musicNote = collision.gameObject.GetComponent<AbstractCollidable>();
        if (musicNote == null) return;
        musicNote.ExecuteCollisionResult();
    }

	void OnTriggerExit2D(Collider2D collided)
	{
		var musicNote = collided.gameObject.GetComponent<AbstractCollidable>();
		if (musicNote == null)
			return;

		GameManager.Excitement -= musicNote.GetComponent<MusicNoteAttributes>().ScoreValue * 3;
		Destroy(collided.gameObject);
	}
}
