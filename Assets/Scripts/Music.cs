using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource effect;
    public AudioSource music;

    public bool IsOnEffect;
    public bool IsOnMusic;
    public void Start()
    {
        IsOnEffect = true;
        IsOnMusic = true;
    }
    public void OnOffEffect()
    {
        if (!IsOnEffect)
        {
            effect.mute = false;
            IsOnEffect = true;
        }
        else if (IsOnEffect)
        {
            effect.mute = true;
            IsOnEffect = false;
        }
    }
    public void OnOffMusic()
    {
        if (!IsOnMusic)
        {
            music.mute = false;
            IsOnMusic = true;
        }
        else if (IsOnMusic)
        {
            music.mute = true;
            IsOnMusic = false;
        }
    }
}