using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
	public enum direction {Right, Left, Forward, Back};
	public direction chosenDirection = direction.Right;
	public float length = 1;
 	public float speed = 1;
	private Vector3 target = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    { 
        target = transform.position;
	switch(chosenDirection) {
		case direction.Right:
			target.x += length;
			break;
		case direction.Left:
			target.x -= length;
			break;
		case direction.Forward:
			target.z += length;
			break;
		case direction.Back:
			target.z -= length;
			break;
	}
    }

    private void Update() {
		transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }

	void OnCollisionEnter(Collision collision) {
		length *= -1;
		target = transform.position;
		switch(chosenDirection) {
			case direction.Right:
				target.x += length;
				break;
			case direction.Left:
				target.x -= length;
				break;
			case direction.Forward:
				target.z += length;
				break;
			case direction.Back:
				target.z -= length;
				break;
		}
	}
}
