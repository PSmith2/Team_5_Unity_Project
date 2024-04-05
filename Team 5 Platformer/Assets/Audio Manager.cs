using System;
using UnityEngine;
using System.Collections;


public class AudioManager : MonoBehaviour
{
    [Header("------ Audio Source -----")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("----- Audio Clip -----")]
    public AudioClip background;
    public AudioClip Jump;
    public AudioClip DamageTaken;
    public AudioClip Victory;
    public AudioClip Victory2;
    public AudioClip pickUp;
    public AudioClip OneUp;


    private void Start()
    {
        musicSource.clip = background;
        musicSource.loop = true;
        musicSource.Play();
        

    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    public void endGame() 
    {
        musicSource.clip = Victory;
        musicSource.loop = false;
        musicSource.Play();
        StartCoroutine(PlayVictory2AfterDelay(6f)); // Wait for the length of Victory before playing Victory2



    }

    private IEnumerator PlayVictory2AfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Wait for the specified delay
        musicSource.clip = Victory2;
        musicSource.loop = true;
        musicSource.Play();
    }
}


