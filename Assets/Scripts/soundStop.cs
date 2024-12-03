using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundStop : MonoBehaviour
{
    public AudioSource audioSource;
    public void StopSound()
    {
        audioSource.Stop();
    }
}
