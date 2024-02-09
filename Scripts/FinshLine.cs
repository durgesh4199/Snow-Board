using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinshLine : MonoBehaviour
{
    [SerializeField] float ReloadDelay = 1.5f;
    [SerializeField] ParticleSystem finshEffect;
    [SerializeField] AudioClip finshSFX;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finshEffect.Play();
            Invoke("ReloadScene", ReloadDelay);
            GetComponent<AudioSource>().PlayOneShot(finshSFX);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
