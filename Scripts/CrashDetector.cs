using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float ReloadScene = 1.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool disableEffects = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            GetComponent<PlayerController>().DisableControls();           
            Invoke("ReloadScene1", ReloadScene);
            CrashEffects();      
        }
    }

    void CrashEffects()
    {
        if (disableEffects == false)
        {
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            disableEffects = true;
        }
    }
    void ReloadScene1()
    {
        SceneManager.LoadScene("Level1");
    }
}
