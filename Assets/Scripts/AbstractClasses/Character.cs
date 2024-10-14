using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public string characterName;
    public float characterHealth;

    public Character(string name, float health)
    {
        characterName = name;
        characterHealth = health;
    }

    public abstract void Attack();
    public abstract void Attack(int damage);

    public virtual void Heal(float amount)
    {
        characterHealth += amount;
        Debug.Log($"{characterName} healed for {amount}, current health: {characterHealth}.");
    }

}
