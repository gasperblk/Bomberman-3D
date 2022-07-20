using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillMe : MonoBehaviour
{
	public string levelToLoad = "";
	public string whenICollideWithTag = "";

    	void OnCollisionEnter(Collision collision)
    	{
        	if (collision.gameObject.tag == whenICollideWithTag)
       		{
        		if (!(levelToLoad == "")) {
				SceneManager.LoadScene(levelToLoad);
			}
        	}
    	}
}
