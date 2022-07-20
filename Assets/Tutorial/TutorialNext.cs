using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialNext : MonoBehaviour
{
    void NextScreen() 
    {
		SceneManager.LoadScene("Tutorial2");
    }
}
