using UnityEngine;
using System.Collections;

public class CharacterWalk : MonoBehaviour
{
	public float moveSpeed;

	// Update is called once per frame
	void Update()
	{
		float h = Input.GetAxis("Horizontal");
	

		transform.Translate(new Vector3(h, 0, 0) * Time.deltaTime * moveSpeed);
	}


}