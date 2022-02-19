using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class GameSoundController : MonoBehaviour
{
    [Serializable]
    public struct Clips
    {
        public string name;
        public AudioClip audioClip;
    }

    [SerializeField] private Clips[] _clips;

    public AudioClip GetFootstepSound(string name)
    {
        List<AudioClip> availableClips = new List<AudioClip>();
        foreach(Clips currentClip in _clips)
        {
            if (currentClip.name == name)
            {
                availableClips.Add(currentClip.audioClip);
            }
        }
        // Get a random clip from the list and play it
        int clipIdx = Random.Range(0, availableClips.Count);
        return availableClips[clipIdx];
    }
}
