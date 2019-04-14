using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Items/Weapons/Fire Arms/Armor Piercing")]
public class ArmorPiercing : FireArm
{
    [SerializeField]//the maximum numer of enemies the bullet can penetrate through
    private int penetration;
    public int Penetration { get { return penetration; } set { value = penetration; } }

    public override void Attack()
    {
        throw new System.NotImplementedException();
    }

    public override void Buy()
    {
        throw new System.NotImplementedException();
    }

    public override void Drop()
    {
        throw new System.NotImplementedException();
    }

    public override void Equip()
    {
        throw new System.NotImplementedException();
    }

    public override void Sell()
    {
        throw new System.NotImplementedException();
    }
}
