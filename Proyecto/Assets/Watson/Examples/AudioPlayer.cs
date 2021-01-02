using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip audio;
    public AudioSource source;

    public void playAudio()
    {
        source.PlayOneShot(audio);
    }
}
