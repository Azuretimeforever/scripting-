using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //enemy movement speed
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    void Update()
    {
        //Cambia la posicion del npc a una nueva cada frame
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        //gira al npc cada frame para que mire al objetivo
        transform.LookAt(target.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        player.TakeDamage(playerDamage);
    }
}
