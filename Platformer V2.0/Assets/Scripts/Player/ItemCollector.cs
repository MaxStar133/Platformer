using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class ItemCollector : MonoBehaviour
{

    [SerializeField] private Text cherriesText;
    [SerializeField] private AudioSource collectionSoundEffect;

    private void Awake()
    {
        Score.currentScoreCherry = Score.scoreCherry;
        cherriesText.text = "" + Score.scoreCherry;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision != null)
        {
            if (collision.gameObject.CompareTag("Cherry"))
            {
                collectionSoundEffect.Play();
                Destroy(collision.gameObject);
                Score.currentScoreCherry++;
                Debug.Log("Cherries: " + Score.currentScoreCherry);
                cherriesText.text = "" + Score.currentScoreCherry;
            }
        }
    }

}
