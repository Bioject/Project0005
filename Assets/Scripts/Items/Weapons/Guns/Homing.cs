using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Items/Weapons/Fire Arms/Homing")]
public class Homing : FireArm
{

    [SerializeField]
    private float trackingDistance;
    public float TrackingDistance { get { return trackingDistance; } set { value = trackingDistance; } }
    private float splashRadius;
    public float SplashRadius { get { return splashRadius; } set { value = splashRadius; } }

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