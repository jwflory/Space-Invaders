using UnityEngine;
using System.Collections;

public class PlayerMissile : MonoBehaviour
{
	private Player player;
	
	// Use this for initialization
	void Start ()
	{
		// Add initial force.
		rigidbody.AddForce (0, 1000, 0);
		
		player = GameObject.Find ("Tank").GetComponent < Player > ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (transform.position.y > 17)
		{
			Destroy (gameObject);
			
			player.HasFired = false;
		}
	}

	// Check to see if a collision has occured.
	
}
