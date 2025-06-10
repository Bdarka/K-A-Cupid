using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

// Seperating out the sound system cause it feels more organized

public class VNSoundSystem : MonoBehaviour
{
    public string songName;

    public List<AudioClip> musicList = new List<AudioClip>();
    public AudioSource MusicSource;
    public AudioClip MusicClip;

    public AudioSource SFXAudio;
    public AudioClip SFXClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayNewMusic(songName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayNewMusic(string newSongName)
    {
        // Initally I used the resources folder but this was inefficient
        // MusicClip = Resources.Load(newSongName) as AudioClip;

        for (int i = 0; i < musicList.Count; i++)
        {
            if (musicList[i].name == newSongName)
            {
                MusicClip = musicList[i];
            }

            MusicSource.resource = MusicClip;
            MusicSource.Play();
        }
    }
}
