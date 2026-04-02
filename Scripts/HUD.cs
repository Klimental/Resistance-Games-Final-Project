using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField]
    private Sprite[] HealthSprites;
    [SerializeField]
    private Image HealthUI;
    [SerializeField]
    private Sprite lootIcon;
    [SerializeField]
    private Sprite killsIcon;

    private PlayerController player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }


    void Update()
    {
        //this system basically requires an array of sprites for varying levels of health. The player's health is a value that must match the size of the array
        if (player.currentHealth < 0) { player.currentHealth = 0; }
        {

            HealthUI.sprite = HealthSprites[player.currentHealth];
        }
    }
}
