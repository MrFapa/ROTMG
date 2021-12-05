using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapon")]
public class Weapons : ScriptableObject
{
    [SerializeField] string weaponsName;
        public string WeaponName{get{return weaponsName;}}
    [SerializeField] float range;
        public float Range{get{return range;}}
    [SerializeField] int firerate;
        public int Firerate{get{return firerate;}}
    [SerializeField] float speed;
        public float Speed{get{return speed;}}
    [SerializeField] GameObject bullet;
        public GameObject Bullet{get{return bullet;}}

    //[SerializeField] Sprite sprite;
      //  public Sprite Sprite{get{return sprite;}}
        
}
