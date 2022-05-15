using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poop : MonoBehaviour {

    [SerializeField]
    private Animator animator;
    public AudioClip die;
    private Rigidbody2D rigidbody;
    AudioSource audioSource;
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            MiniGameManager.Instance.Score();
            animator.SetTrigger("poop");
            GetComponent<AudioSource>().Play();
        }

        if (collision.gameObject.tag == "Player")
        {
            audioSource.clip = die;
            audioSource.Play();
            MiniGameManager.Instance.GameOver();
            animator.SetTrigger("poop");
        }
    }
}
