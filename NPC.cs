using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //Vida del NPC
    public int health = 1;

    //Nivel de ese NPC
    public int level = 1;

    public float speed = 1.2f;

    void Start()
    {
        health += level;
        print("Player health:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        //creando una variable para guardar la posicion del npc
        Vector3 newPosition = transform.position;
        //cambiando la posicion z del npc de acuerdo a la velocidad y al frame
        newPosition.z += speed * Time.deltaTime;
        //actualizo la posicion del npc con la variable de antes
        //esto hace que cada vez que newPosition cambie, transform.position tambien cambie
        transform.position = newPosition;
    }
}
