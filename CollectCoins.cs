using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public class Coin : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            Player player = other.GetComponent<Player>();
            //El numero de monedas se actualiza
            player.CollectCoins();
            //La moneda coleccionada es destruida
            Destroy(gameObject);
        }
    }
}