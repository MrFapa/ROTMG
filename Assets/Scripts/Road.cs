using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Perks;

public class Road : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other){
        if (other.tag.Equals("Player"))
            other.GetComponent<PlayerController>().AddPerks(PerkType.fast);
    }

    void OnTriggerExit2D(Collider2D other){
        if (other.tag.Equals("Player"))
            other.GetComponent<PlayerController>().RemovePerks(PerkType.fast);
    }
}
