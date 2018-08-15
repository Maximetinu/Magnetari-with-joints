using UnityEngine;

public class BallController : MonoBehaviour {

	public float factor = 1.0f;
	
	// Update is called once per frame
	void Update () {
		float horizontal_axis = Input.GetAxis("Horizontal");
		float vertical_axis = Input.GetAxis("Vertical");

		Vector3 strength = new Vector3(horizontal_axis, 0, vertical_axis);

		this.GetComponent<Rigidbody>().AddForce(strength * factor);

		// TURBOOOO!!! NO COOLDOWN RULES (it could be better, for example based on the sum of all the attached masses)
		if (Input.GetKey(KeyCode.Space)) {
			this.GetComponent<Rigidbody>().velocity *= 1.1f;
		}
	}

}
