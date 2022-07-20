using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	
	public float moveSpeed = 3.0f;

	private CharacterController myController;

	void Start () {
		myController = gameObject.GetComponent<CharacterController>();
	}
	
	void Update () {

		Vector3 movementZ = Input.GetAxis("Vertical") * Vector3.forward * moveSpeed * Time.deltaTime;
		Vector3 movementX = Input.GetAxis("Horizontal") * Vector3.right * moveSpeed * Time.deltaTime;

		Vector3 movement = transform.TransformDirection(movementZ+movementX);

		myController.Move(movement);
	}
}
