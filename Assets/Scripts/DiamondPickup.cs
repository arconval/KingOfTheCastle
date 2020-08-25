using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondPickup : MonoBehaviour
{
    [SerializeField] AudioClip diamondPickupSFX;
    [SerializeField] int diamondScore = 5;
    void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().AddToScore(diamondScore);
        AudioSource.PlayClipAtPoint(diamondPickupSFX, Camera.main.transform.position);
        Destroy(gameObject);
        
    }
}
