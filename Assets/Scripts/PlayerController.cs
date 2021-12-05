using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Perks;

public class PlayerController : MonoBehaviour
{
    GameObject player;
    float speed;
    Vector2 movement;
    Rigidbody2D rb;
    ArrayList perks;
   
    void Start()
    {
        player = this.gameObject;
        this.rb = GetComponent<Rigidbody2D>();
        perks = new ArrayList();
    }
    
    void Update(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() // das Speed mit allen Effekten
    {
        UpdateSpeed();
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void UpdateSpeed(){ // Alle Speed-Effekte angewendet
        float baseSpeed = this.GetComponent<PlayerStats>().MovementSpeed;
        this.speed = baseSpeed;
        foreach (PerkType perk in perks ){
           this.speed += baseSpeed * PerkHandler.getPerkValue(perk);
        }
    }

    public void AddPerks(PerkType type){
        perks.Add(type);
    }

    public void RemovePerks(PerkType type){
        if(perks.Contains(type)){
            perks.Remove(type);
        }
    }
}


