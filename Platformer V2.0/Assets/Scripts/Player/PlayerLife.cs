using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private AudioSource deathSoundEffect;
    [SerializeField] private AudioSource finishSoundEffect;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
     
        }

  
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name=="Finish")
        {
            finishSoundEffect.Play();
            rb.bodyType = RigidbodyType2D.Static;
            anim.SetTrigger("death");
            Invoke("CompleteLevel", 2f);
        }
    }

    private void Die()
    {
        deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
        Invoke("RestartLevel", 1.15f);
    }



    private void RestartLevel()
    {
        Score.currentScoreCherry = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


    private void CompleteLevel()
    {
        Score.scoreCherry = Score.currentScoreCherry;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
