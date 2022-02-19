using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardSoundController : MonoBehaviour
{
    private AudioSource _source;
    [SerializeField] private GameSoundController _soundController;

    private void Awake()
    {
        _source = GetComponent<AudioSource>();
    }

    public void TriggerWalkSound()
    {
        Ray ray = new Ray(transform.position, -transform.up);
        RaycastHit hit;

        // Get the material under the player
        if (Physics.Raycast(ray, out hit, 3000.0f))
        {
            // Get the material name and play that appropriate material sound
            AudioClip floorSoundClip = _soundController.GetFootstepSound($"{hit.collider.tag} Footstep");
            _source.PlayOneShot(floorSoundClip);
        }
    }
}
