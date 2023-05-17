using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsHandling : MonoBehaviour
{
    [SerializeField] private AudioSource birdSound;
    [SerializeField] private AudioSource dogSound;

    public void Bark()
    {
        dogSound.Play();
    }
    public void Croak()
    {
        birdSound.Play();
    }

}
