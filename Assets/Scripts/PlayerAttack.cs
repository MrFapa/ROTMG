using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] Weapons weapon; // Welche Waffe (unity)

    float attackSpeed;
    float nextTimeToShot = 0;

    void Start()
    {
        attackSpeed = this.GetComponent<PlayerStats>().AttackSpeed;
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
            shot();
    }

    void shot()
    {
        if (Time.time >= nextTimeToShot)
        { // Zeit bis zum nächsten Schuss

            float firerate = (weapon.Firerate * attackSpeed);
            nextTimeToShot = Time.time + 1f / firerate;

            // Richung Maus und Rotation
            Vector3 mousePos = Camera.main.ScreenToWorldPoint((Input.mousePosition));
            mousePos.z = 0;     // z = 0 sonst verschwindet
            Vector3 dir = (mousePos - this.transform.position).normalized;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;

            // neuer Schuss
            GameObject bulletGameObject = Instantiate(weapon.Bullet, this.transform.position, Quaternion.Euler(new Vector3(0, 0, angle)));
            Projectile bullet = bulletGameObject.GetComponent<Projectile>();


            // Stats der Bullet, abhängig von Weapon
            bullet.setDirection(dir);
            bullet.setSpeed(weapon.Speed);
            bullet.setRange(weapon.Range);
        }
    }
}
