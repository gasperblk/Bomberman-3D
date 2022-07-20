using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlockCounter : MonoBehaviour
{
    public Text counterMonsterText;
    public Text counterBlockText;
    private int counterBlock;
    private int counterMonster;

    void Update()
    {
        counterBlock = GameObject.FindGameObjectsWithTag("Unicljiva").Length;
        counterMonster = GameObject.FindGameObjectsWithTag("Monster").Length;
        counterBlockText.text = counterBlock.ToString();
        counterMonsterText.text = counterMonster.ToString();
        
        if(counterBlock == 1)
        {
            GameObject.FindWithTag("Unicljiva").GetComponent<Renderer>().material.color = Color.black;
        } 
        if(counterMonster == 0 && counterBlock == 0){
            //SceneManager.LoadScene("nextLevel");
        }       
    }
}
