using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterWalk : MonoBehaviour
{
	public float moveSpeed;
	public int jumpforce;

	// Update is called once per frame
	void Update()
	{
		float h = Input.GetAxis("Horizontal");
	

		transform.Translate(new Vector3(h, 0, 0) * Time.deltaTime * moveSpeed);

		if (Input.GetKey ("Jump")){

			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0,1).normalized * jumpforce);
		}
	}


}