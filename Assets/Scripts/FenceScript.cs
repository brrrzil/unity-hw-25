using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class FenceScript : MonoBehaviour
{
    [SerializeField] private PlayableDirector lightTimeline;

    private AudioSource audioSource;

    public void OpenGate()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        lightTimeline.Play();
    }
}