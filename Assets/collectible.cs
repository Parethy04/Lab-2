using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private int ammoAmount = 10;  // ammo gained

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player player = other.GetComponent<player>();

            if (player != null)
            {
                player.collection(); // collection if needed

                // Gain ammo.
                player.GainAmmo(ammoAmount);

                Destroy(gameObject); // Destroy the ammo box.
            }
        }
    }
}
