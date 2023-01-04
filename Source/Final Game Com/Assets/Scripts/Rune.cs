using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rune : MonoBehaviour
{
    public Player player;
    public int requiredOrbs = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("FirstPersonController").GetComponent<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "FirstPersonController")
        {
            if (player.orbs >= requiredOrbs)
            {
                player.BeatLevel();
            }
        }
    }
}
