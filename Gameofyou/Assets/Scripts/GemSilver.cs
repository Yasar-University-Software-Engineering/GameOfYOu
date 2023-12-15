using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemSilver : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;


    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 1000;
        collectSound.Play();
        Destroy(gameObject);
    }
}