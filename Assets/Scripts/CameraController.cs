using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject player;
    
    void Update()
    {
        Vector3 playerPosition = player.transform.position;
        this.transform.position = new Vector3(playerPosition.x, playerPosition.y, -10);
    }
}
