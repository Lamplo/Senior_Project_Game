using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound
{  
    public string name; // The reference name for this sound effect
    public AudioClip audioClip; // The audio clip assigned to this sound

    [Range(0f, 1f)]
    public float volume = 1;

    [Range(.1f, 3f)]
    public float pitch = 1;

    public bool loop = false;

    [HideInInspector] // We hide this attribute because the AudioManager will initialize this for us
    public AudioSource audioSource;
}
