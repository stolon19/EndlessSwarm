using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Sprite image;
    public string title;
    public string description;
    public int damage;
    public float attackSpeed;
    public int critChance;
    public int critDmg;
    public int knockback;
    public float weight;
    public int price;
    public int quantity;
    public bool isRanged;

    private void Awake()
    {
        description =
            $"{description}\n" +
            $"Damage: {damage}\n" +
            $"Attack Speed: {attackSpeed}/s\n" +
            $"Crit. Chance: {critChance}%\n" +
            $"Crit. Damage: {critDmg}%\n" +
            $"Knockback: {knockback}\n" +
            $"Weight: {weight} Kg\n" +
            $"Price: €{price}";
    }
}
