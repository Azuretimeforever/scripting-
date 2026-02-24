using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;
    public AudioSource audioSource;
    public AudioClip collectSound;
    private int health = 10;

    public void CollectCoins()
    {
        coins++;
        audioSource.PlayOneShot(collectSound);
        print("Collected coins: " + coins);
    }



        //un metodo que hace que te baje la vida
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Player's health:" + health);
    }

}

