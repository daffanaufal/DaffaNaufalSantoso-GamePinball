using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpercontroller : MonoBehaviour
{
    public Collider bola;
    public float multipler;
    public Color color;
    public float score;

    public AudioManager audioManager;
    public VFXManager VFXManager;
    public ScoreManager scoreManager;

    private Renderer renderer;
    private Animator animator;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        renderer.material.color = color;   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody bolaRig = bola.GetComponent<Rigidbody>();
            bolaRig.velocity *= multipler;

            //animasi
            animator.SetTrigger("hit");

            //sfx
            audioManager.PlaySFX(collision.transform.position);

            //vfx
            VFXManager.PlayVFX(collision.transform.position);

            //tambah score saat menabrak bumper
            scoreManager.AddScore(score);

        }
    }
}
