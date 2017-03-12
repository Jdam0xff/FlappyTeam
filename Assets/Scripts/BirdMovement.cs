using UnityEngine;

public class BirdMovement : MonoBehaviour {

	#region Veriables

	Vector3 velocity = Vector3.zero;
	public Vector3 gravity;
	public Vector3 flapVelocity;

	bool didFlap = false;

	#endregion
	
	#region Unity Methods

	void Update () 
	{
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
		{
			//Debug.Log("Hi");
			didFlap = true;
		}
	}

	void FixedUpdate()
	{
		velocity += gravity * Time.deltaTime;

		if(didFlap == true)
		{
			didFlap = false;
			velocity += flapVelocity;
		}
		transform.position += velocity * Time.deltaTime;
	}
		#endregion
}
