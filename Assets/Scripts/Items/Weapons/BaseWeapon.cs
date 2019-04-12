using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWeapon : BaseItem
{

    [SerializeField]
    private int requiredLevel;
    public int RequiredLevel { get { return requiredLevel; } set { requiredLevel = value; } }
    public static int idNumber;
    private int id;
    public int ID { get { return id; } set { id = value; } }
    private bool isEquipped;
    public bool IsEquipped { get { return isEquipped; } set { isEquipped = value; } }
    public enum WeaponType { Sword, Axe, Dagger, Bow };
    [SerializeField]
    private WeaponType type;
    public WeaponType Type { get { return type; } set { type = value; } }
    [Header("Damage")]
    [SerializeField]
    private Vector2 minMaxDamage;
    public Vector2 MinMaxDamage { get { return minMaxDamage; } set { value = minMaxDamage; } }
    private float m_damage;
    public float Damage { get { return Random.Range(MinMaxDamage.x, MinMaxDamage.y); } set { value = m_damage; } }
    [Header("Attack Speed")]
    [SerializeField]
    private float attackSpeed;
    public float AttackSpeed { get { return attackSpeed; } set { attackSpeed = value; } }
    [Header("Range")]
    [SerializeField]
    private float range;
    public float Range { get { return range; } set { range = value; } }
    [Header("Attack Rating")]
    [SerializeField]
    private float attackRating;
    public float AttackRating { get { return attackRating; } set { attackRating = value; } }
    [Header("Durability")]
    [SerializeField]
    private int maxDurability;
    public int MaxDurability { get { return maxDurability; } set { value = maxDurability; } }
    private int durability;
    public int Durability { get { return durability; } set { value = durability; } }
    [Header("Statstics")]
    [SerializeField]
    private float criticalHit;
    public float CriticalHit { get { return criticalHit; } set { criticalHit = value; } }
    [SerializeField]
    private float criticalDamage;
    public float CriticalDamage { get { return criticalDamage; } set { criticalDamage = value; } }
    [Header("Imbue")]
    [SerializeField]
    private OffenseImbue imbue = new FireDamage();
    public OffenseImbue Imbue { get { return imbue; } set { imbue = value; } }

    public abstract void Attack();
    public abstract void Equip();
}
