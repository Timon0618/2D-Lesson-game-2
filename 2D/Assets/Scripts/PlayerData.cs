using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerData
{
    
    public static float SoundVolume;
    public static float MusicVolume;


    public static void SetSoundVolume(float volume)
    {
        SoundVolume = volume;
    }


    public static void SetMusicVolume(float volume)
    {
        MusicVolume = volume;
    }
}
