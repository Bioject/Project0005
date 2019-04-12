using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Items/Weapon")]
public class Weapon : BaseWeapon
{
    private void Start()
    {
        //providing the object with a unique id number
        idNumber++;
        ID = idNumber;
    }

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
