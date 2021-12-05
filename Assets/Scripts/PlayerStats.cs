using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
   [SerializeField] float movementSpeed;
        public float MovementSpeed{get{return movementSpeed;}}
    [SerializeField] float attackSpeed;
        public float AttackSpeed{get{return attackSpeed;}}
    
}
