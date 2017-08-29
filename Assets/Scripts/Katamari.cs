using UnityEngine;

public class Katamari : MonoBehaviour {
	bool hasJoint;
	void OnCollisionEnter(Collision collision) {
		// CHECK HERE IF COLLISION IS WITH THE PLAYER OR ATTACHED CUBES, WE DON'T WANT FREE CUBES TO CONNECT EACH OTHER
		if (collision.gameObject.GetComponent<Rigidbody>() != null && !hasJoint) {
			gameObject.AddComponent<FixedJoint>();
			gameObject.GetComponent<FixedJoint>().connectedBody = collision.rigidbody;
			hasJoint = true;
		}
	}
}


// Bonus level: since Magnetari is about magnetism, why don't add fake magnetism forces (like gravity) to the balls? 
// Could be a skill with long cooldown...
