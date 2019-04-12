using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseClass : ScriptableObject {

    [SerializeField]
    private new string name;
    public string Name { get { return name; } set { name = value; } }
    [Range(1,99)]
    [SerializeField]
    private int level;
    public int Level { get { return level; } set { level = value; } }
    [SerializeField]
    private int health;
    public int Health { get { return health; } set { health = value; } }
    [SerializeField]
    private float defenseRating;
    public float DefenseRating { get { return defenseRating; } set { defenseRating = value; } }
    [SerializeField]
    private float attackSpeed;
    public float AttackSpeed { get { return attackSpeed; } set { attackSpeed = value; } }
    [SerializeField]
    private AttackSystem atackSystem = new AttackSystem();
    public AttackSystem AtackSystem { get { return atackSystem; } set { atackSystem = value; } }
    [SerializeField]
    private HitSystem hitSystem = new HitSystem();
    public HitSystem HitSystem { get { return hitSystem; } set { hitSystem = value; } }
    [SerializeField]
    private CriticalSystem criticalSystem = new CriticalSystem();
    public CriticalSystem CriticalSystem { get { return criticalSystem; } set { criticalSystem = value; } }

    [SerializeField]
    private Stats stats;
    public Stats Stats { get { return stats; } set { stats = value; } }
    private bool canMove;//this is used to control and disable to players movement
    public bool CanMove { get { return canMove; } set { canMove = value; } }

    public abstract void Attack();
    public abstract void SpecialAttack();
    public abstract void EquipWeapon(BaseWeapon weapon);
    public abstract void EquipArmor(BaseArmor armor);
    public abstract void UsePotion(BasePotion potion);

}

[System.Serializable]
public class Stats
{
    public int constitution = 5;
    public int strength = 5;
    public int dexterity = 5;
    public int intelligence = 5;
    public int agility = 5;
    public int charisma = 5;
}

[System.Serializable]
public class AttackSystem
{
    public Vector2 minMaxDamage = new Vector2(3, 6);

    public float GetDamage()
    {
        float damage = Random.Range(minMaxDamage.x, minMaxDamage.y);
        return damage;
    }
}

[System.Serializable]
public class HitSystem
{
    public float attackRating = 50;

    public bool HitDetected(float targetsDefense)
    {
        float hitChance = Random.Range(0.00f, 1f);
        if (hitChance <= attackRating/(attackRating + targetsDefense))
            return true;
        else
            return false;
    }
}

[System.Serializable]
public class CriticalSystem
{
    public float criticalChance = 30.0f;
    public float criticalDamage = 2.0f;

    public bool GetCriticalHit()
    {
        if (Random.Range(0, 1001) <= criticalChance)
            return true;
        else
            return false;
    }//end of GetCriticalChance()
}//end of class