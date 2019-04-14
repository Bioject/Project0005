using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FireArm : BaseWeapon {

    [SerializeField]
    public enum AmmoType { HandgunBullets, ShotgunShells, MachinegunBullets, RifleRounds, MagnumRounds, ExplosiveRounds }
    [SerializeField]
    private AmmoType ammo;
    public AmmoType Ammo { get { return ammo; } set { ammo = value; } }
    [SerializeField]
    private AudioController reloadSound;
    public AudioController ReloadSound { get { return reloadSound; } set { reloadSound = value; } }
    [SerializeField]
    private AudioController emptySound;
    public AudioController EmptySound { get { return emptySound; } set { emptySound = value; } }
    [SerializeField]
    private float attackRange;
    public float AttackRangee { get { return attackRange; } set { value = attackRange; } }
    [SerializeField]
    private float reloadSpeed;
    public float ReloadSpeed { get { return reloadSpeed; } set { value = reloadSpeed; } }
    [SerializeField]
    private int capacity;
    public int Capacity { get { return capacity; } set { value = capacity; } }
    [SerializeField]
    private float bulletSpeed;
    public float BulletSpeed { get { return bulletSpeed; } set { value = bulletSpeed; } }
    [SerializeField]
    private float force;
    public float Force { get { return force; } set { value = force; } }
}
