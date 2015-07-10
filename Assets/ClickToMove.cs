using UnityEngine;
using System.Collections;

public class ClickToMove : MonoBehaviour {
	void Update () {
		RaycastHit hit;
		Vector3 fwd = transform.TransformDirection (Vector3.forward);

		if (Physics.Raycast (transform.position, fwd, out hit) && hit.transform.tag == "Waypoint") {
			hit.transform.SendMessage("Highlight", SendMessageOptions.DontRequireReceiver);
			
			if (Input.GetMouseButtonDown (0)) {
				transform.position = hit.transform.position;
			}
		}
	}
}
