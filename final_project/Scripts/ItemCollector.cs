using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int melons = 0;

    [SerializeField] private Text pointText;

    [SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Melon"))
        {
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            melons++;
            pointText.text = "Punkty: " + melons;
        }
    }
}