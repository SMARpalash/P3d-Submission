using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int orbs = 0;
    public AudioSource playerSounds;
    public AudioClip winSound;
    public Image levelSplash;

    public void BeatLevel()
    {
        levelSplash.gameObject.SetActive(true);
        playerSounds.PlayOneShot(winSound);
    }
}
