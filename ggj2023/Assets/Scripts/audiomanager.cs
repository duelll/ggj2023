using UnityEngine.Audio;
using System;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    public sounds[] sound;

    void Awake()
    {
        foreach (sounds s in sound)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip; 

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        Play("buttonclick");
    }

    public void Play (string name)
    {
        sounds s = Array.Find(sound, sounds => sounds.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found!");
            return;
        }
        s.source.Play();
    }

}
