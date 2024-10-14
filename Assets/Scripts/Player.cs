using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IMove, IDamageable
{
    public Player(string name, float health) : base("Player", 100f) {} // doesnt change the name and health has to be done in start or awake
    void Awake()
    {
        characterName = "Player";
        characterHealth = 100f;
    }

    public override void Attack()
    {
        Debug.Log($"{characterName} attacks");
    }

    public override void Attack(int damage)
    {
        Debug.Log($"{characterName} attacks for {damage}");
    }

    public void Move()
    {
        Debug.Log($"{characterName} moves");
    }

    public void TakeDamage(float damage)
    {
        characterHealth -= damage;
        Debug.Log($"{characterName} takes {damage} damage. They have {characterHealth} health");
    }
}
