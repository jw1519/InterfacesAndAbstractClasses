using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<Character> characters = new();

    [SerializeField] Player player;
    [SerializeField] Enemy enemy;
    [SerializeField] NPC npc;

    // Start is called before the first frame update
    void Start()
    {
        characters.Add(player);
        characters.Add(enemy);
        characters.Add(npc);

        foreach (Character character in characters)
        {
            character.Attack();
        }
    }

}
