using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Items/Weapons/Fire Arms/Scatter Shot")]
public class ScatterShot : FireArm
{

    [SerializeField]
    private int shotsPerFire;
    public int ShotsPerFire { get { return shotsPerFire; } set { value = shotsPerFire; } }

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