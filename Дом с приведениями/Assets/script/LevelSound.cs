using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSound : MonoBehaviour
{
    private static readonly string MusicPref = "MusicPref";
    private float musicFloat;
    public AudioSource musicAudio;

    private void Awake()
    {
        LevelSoundSettings();
    }

    private void LevelSoundSettings()
    {
        musicFloat = PlayerPrefs.GetFloat(MusicPref);

        musicAudio.volume = musicFloat;

    }
}
