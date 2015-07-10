using UnityEngine;
using System.Collections;

public class HighlightMe : MonoBehaviour {
	new private Renderer renderer;
	private float timer;

	void Start() {
		renderer = gameObject.GetComponent<Renderer> ();
		renderer.material.color = Color.white;
		timer = Time.time;
	}

	public void Highlight() {
		renderer.material.color = Color.red;
		timer = Time.time;
	}

	void Update() {
		float lerpValue = Time.time - timer;

		if(lerpValue > 1) {
			renderer.material.color = Color.white;
		} else {
			renderer.material.color = Color.Lerp (Color.red, Color.white, lerpValue);
		}
	}
}
