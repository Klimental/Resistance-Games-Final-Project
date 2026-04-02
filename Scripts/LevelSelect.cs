using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    private PlayerController playerController; //create this reference to manipulate when the player can move

    void Start()
    {
        playerController = GameObject.Find("PlayerCharacter").GetComponent<PlayerController>(); //initialize in a start method for everything that requires it
        playerController.canMove = false; //disable movement
        playerController.GetComponent<SpriteRenderer>().enabled = false; //disable sprite renderer
    }

    public void startRun()
    {
        //later, we'll have the conditional: "if player loot is greater than required loot, load game scene"
        SceneManager.LoadScene(1);
    }
}
