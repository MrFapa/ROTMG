using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Perks;

public class Water : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if (other.tag.Equals("Player"))
            other.GetComponent<PlayerController>().AddPerks(PerkType.slow);
    }

    void OnTriggerExit2D(Collider2D other){
        if (other.tag.Equals("Player"))
            other.GetComponent<PlayerController>().RemovePerks(PerkType.slow);
    }
}
