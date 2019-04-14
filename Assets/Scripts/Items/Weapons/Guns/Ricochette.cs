using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Items/Weapons/Fire Arms/Ricochette")]
public class Ricochette : FireArm
{

    [SerializeField]//the maximum number the bullets can ricochette
    private int rebounds;
    public int Rebounds { get { return rebounds; } set { value = rebounds; } }

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