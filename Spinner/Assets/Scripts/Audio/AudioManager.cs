using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance {get;private set;}
    
   [SerializeField] private Sound[] sounds;
    
    private void Awake(){
        // Check Singleton
        if(Instance == null) Instance = this;
        else if(Instance != null) {
            Destroy(this);
            Debug.LogWarning("Cannot have more than one copy of InputManager");
        }

        foreach (Sound s in sounds){
            // Add a sound component to this object for the given sound AND assiging it to that sound's audio source
            s.audioSource = gameObject.AddComponent<AudioSource>();
            // Initialize this sound's audio source
            s.audioSource.clip = s.audioClip;
            s.audioSource.volume = s.volume;
            s.audioSource.pitch = s.pitch;
            s.audioSource.loop = s.loop;
        }
    }

    private void Start()
    {
        // Play the music
        PlaySound("Music");
    }

    public void PlaySound(string soundName)
    {
        // Try to find the sound in the list of sounds based on the name given
        Sound sound = Array.Find(sounds, sound => sound.name == soundName);

        // Check to see if we found the sound or not
        if (sound == null){
            Debug.LogWarning("Could not find sound");
            return;
        }

        // the sound was found, play it!
        if (!sound.audioSource.isPlaying){
            sound.audioSource.Play();
        }
    }

    public void StopSound(string soundName)
    {
        // Try to find the sound in the list of sounds based on the name given
        Sound sound = Array.Find(sounds, sound => sound.name == soundName);

        // Check to see if we found the sound or not
        if (sound == null){
            Debug.LogWarning("Could not find sound");
            return;
        }

        // the sound is playing, stop it!
        if (sound.audioSource.isPlaying){
            sound.audioSource.Stop();
        }
    }



}
