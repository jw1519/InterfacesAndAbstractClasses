using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Character
{
    public NPC(string name, float health) : base(name, health)  {}

    public override void Attack()
    {
        Debug.Log($"{characterName} does not engage in combat");
    }

    public override void Attack(int damage)
    {
        Debug.Log($"{characterName} does not engage in combat");
    }

    public void Talk()
    {
        Debug.Log($"{characterName} says: \"Welcome\".");
    }
}
