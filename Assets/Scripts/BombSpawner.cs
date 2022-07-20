using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombSpawner : MonoBehaviour
{
	public static BombSpawner bs;
	private GameObject bomb;
	private GameObject detectorX;
	private GameObject detectorZ;
	public float fuzeTime;
	public float distance;
	public int range;
	public float explosionTime = 0.1f;
	public string levelToLoad;
	private bool bombHere = false;
	private int i = 0;
	public bool xStop = false;
	public bool zStop = false;

    void Start()
    {
	if (bs == null) {
		bs = gameObject.GetComponent<BombSpawner>();
	}
    }

    void Update()
    {
        if (Input.GetKey("space") && !bombHere) {
		StartCoroutine(Explosion());
	}
    }

	IEnumerator Explosion() {
		bombHere = true;
		bomb = Instantiate(GameObject.Find("Bomb"));
		bomb.transform.position = transform.position + transform.forward * distance;
		bomb.transform.rotation = Quaternion.identity;
		bomb.transform.position = new Vector3(Mathf.Round(bomb.transform.position.x), 0, Mathf.Round(bomb.transform.position.z));
		
		yield return new WaitForSeconds(0.1f);

		if (bomb) {
			detectorX = Instantiate(GameObject.Find("DetectorX"));
			detectorZ = Instantiate(GameObject.Find("DetectorZ"));
			yield return new WaitForSeconds(fuzeTime);
			detectorX.transform.position = bomb.transform.position;
			detectorZ.transform.position = bomb.transform.position;

			while(i <= range) {
				if (!xStop)
					//detectorX.GetComponent<BoxCollider>().size = new Vector3(i*2, 0.9f, 0.9f);
					detectorX.transform.localScale = new Vector3(i*2, 0.9f, 0.9f);
				if (!zStop)
					//detectorZ.GetComponent<BoxCollider>().size = new Vector3(0.9f, 0.9f, i*2);
					detectorZ.transform.localScale = new Vector3(0.9f, 0.9f, i*2);
				yield return new WaitForSeconds(0.1f);
				i++;
			}
			Destroy(bomb);
			yield return new WaitForSeconds(explosionTime);
			Destroy(detectorX);
			Destroy(detectorZ);
		}
		bombHere = false;
		xStop = false;
		zStop = false;
		i = 0;
	}

	public void StopX() {
		xStop = true;
	}
	public void StopZ() {
		zStop = true;
	}

	public void RangeUp() {
		range++;
	}

	public void NextLevel() {
		SceneManager.LoadScene("NextLevel");
	}

	public void SpeedUp() {
		gameObject.GetComponent<Controller>().moveSpeed += 2;
	}

	public void RangeDown() {
		if (range > 1) {
			range--;
		}
	}

	public void SpeedDown() {
		if (gameObject.GetComponent<Controller>().moveSpeed > 2) {
			gameObject.GetComponent<Controller>().moveSpeed -= 2;
		}
	}
}
