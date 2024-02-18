using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TrampolineJump : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] Animator anim;
    [SerializeField] AudioSource music;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Trampoline")
        {
           
            anim.fireEvents = true;
            music.Play();
            anim.SetTrigger("tramp");
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Trampoline")
            anim.fireEvents = false;
    }
}
   
   
