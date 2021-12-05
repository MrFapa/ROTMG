using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    float range;
    float speed;
    Vector3 dir;
    float traveledDistance;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 temp = dir * speed * Time.fixedDeltaTime;
        this.transform.position += temp; // bewegt sich jetzt um temp

        traveledDistance += temp.magnitude; // länge von temp

        if(this.range <= traveledDistance){ // ende
            GameObject.Destroy(this.gameObject);
        }
    }

    public void setDirection(Vector3 dir){
        this.dir = dir;
    }
    public void setRange(float x){
        this.range = x;
    }
    public void setSpeed(float x){
        this.speed = x;
    }

    public void updatePosition(Vector3 pos){
        this.transform.position = pos;
    }

    void OnTriggerEnter2D(Collider2D other){
        if(!other.tag.Equals("Untagged") && !other.tag.Equals("Player")){
            Destroy(this.gameObject);
        }
    }
}
