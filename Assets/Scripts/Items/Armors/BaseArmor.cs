using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseArmor : BaseItem
{

    [SerializeField]
    private int requiredLevel;
    public int RequiredLevel { get { return requiredLevel; } set { requiredLevel = value; } }
    public static int idNumber;
    private int id;
    public int ID { get { return id; } set { id = value; } }
    private bool isEquipped;
    public bool IsEquipped { get { return isEquipped; } set { isEquipped = value; } }
    public enum ArmorType { Light, Medium, Heavy };
    [SerializeField]
    private ArmorType type;
    public ArmorType Type { get { return type; } set { type = value; } }
    [Header("Defense")]
    [SerializeField]
    private float defense;
    public float Defense { get { return defense; } set { value = defense; } }
    [Header("Durability")]
    [SerializeField]
    private int maxDurability;
    public int MaxDurability { get { return maxDurability; } set { value = maxDurability; } }
    private int durability;
    public int Durability { get { return durability; } set { value = durability; } }
    [Header("Imbue")]
    [SerializeField]
    private DefenseImbue imbue = new FireRes();
    public DefenseImbue Imbue { get { return imbue; } set { imbue = value; } }

    public abstract void Equip();
}
