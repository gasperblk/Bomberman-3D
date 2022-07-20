using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialNext1 : MonoBehaviour
{
    public void PlayGame()
	{
		SceneManager.LoadScene("Tutorial2");
	}
}
