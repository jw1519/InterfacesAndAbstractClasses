using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character, IMove, IDamageable
{
    public Enemy(string enemyName, float enemyhealth) : base(enemyName, enemyhealth) { }

    public override void Attack()
    {
        Debug.Log($"{characterName} attacks");
    }

    public override void Attack(int damage)
    {
        Debug.Log($"{characterName} attacks");
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
