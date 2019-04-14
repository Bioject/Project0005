using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioController : MonoBehaviour {

    AudioSource audioSource;
    [SerializeField]
    AudioClip audioClip;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}

    public void SetVolume(float value)
    {
        audioSource.volume = value;
    }

    public float GetVolume()
    {
        return audioSource.volume;
    }

    public void SetClip(AudioClip clip)
    {
        audioClip = clip;
        audioSource.clip = clip;
    }

    public void Play(float pitch)
    {
        audioSource.pitch = pitch;
        audioSource.PlayOneShot(audioClip, pitch);
    }

    public void PlayLoop(float pitch)
    {
        audioSource.pitch = pitch;
        audioSource.Play();
    }
}
