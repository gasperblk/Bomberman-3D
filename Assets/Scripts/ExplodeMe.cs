using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplodeMe : MonoBehaviour
{	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "DetectorX" || other.gameObject.tag == "DetectorZ") {
			if (gameObject.tag == "Player") {
				SceneManager.LoadScene("EndExplosion");
				return;
			}
			Destroy(gameObject);
		}
		if (gameObject.tag == "Player" && other.gameObject.tag == "Monster") {
			SceneManager.LoadScene("EndMonster");
		}
	}
}
