using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardSoundController : MonoBehaviour
{
    [SerializeField] private AudioClip _carpetSound;
    private AudioSource _source;

    private void Awake()
    {
        _source = GetComponent<AudioSource>();
    }

    public void TriggerWalkSound()
    {
        _source.PlayOneShot(_carpetSound);
    }
}
