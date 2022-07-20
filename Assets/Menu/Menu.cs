using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    
	public void PlayGame()
	{
		CameraRotator.cr.CameraPan();
		SceneManager.LoadScene("Level1");
	}

	public void Tutorial()
	{
		SceneManager.LoadScene("Tutorial1");
	}

	public void QuitGame()
	{
		Debug.Log("QUIT");
		Application.Quit();
	}

	public void PlayLevel2() {
		SceneManager.LoadScene("Level2");
	}
}
