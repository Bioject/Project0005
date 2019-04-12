using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Armor", menuName = "Items/Armor")]
public class Armor : BaseArmor {

    // Use this for initialization
    void Start()
    {
        //providing the object with a unique id number
        idNumber++;
        ID = idNumber;
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
