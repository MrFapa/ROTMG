using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] Weapons weapon; // Welche Waffe (unity)

    float attackSpeed;
    float nextTimeToShot = 0;
    
    void Start(){
        attackSpeed = this.GetComponent<PlayerStats>().AttackSpeed;
    }
    void Update()
    {
        if(Input.GetMouseButton(0))
            shot();
    }

    void shot(){
        if (Time.time >= nextTimeToShot){ // Zeit bis zum nächsten Schuss

            float firerate = (weapon.Firerate * attackSpeed);
            nextTimeToShot = Time.time + 1f / firerate;

            // neuer Schuss
            GameObject bulletGameObject = Instantiate(weapon.Bullet);
            Projectile bullet = bulletGameObject.GetComponent<Projectile>();

            // Richung Maus
            Vector3 mousePos = Camera.main.ScreenToWorldPoint((Input.mousePosition));
            mousePos.z = 0;     // z = 0 sonst verschwindet
            Vector3 dir = (mousePos - this.transform.position).normalized;
            
            // Stats der Bullet, abhängig von Weapon
            bullet.setDirection(dir);
            bullet.updatePosition(this.transform.position);
            bullet.setSpeed(weapon.Speed);
            bullet.setRange(weapon.Range);
        }
    }
}
