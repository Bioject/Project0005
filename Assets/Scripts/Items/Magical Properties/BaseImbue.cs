using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseImbue {
}

//**************Offense
[System.Serializable]
public abstract class OffenseImbue : BaseImbue
{

    [Header("Damage")]
    [SerializeField]
    private Vector2 minMaxDamage;
    public Vector2 MinMaxDamage { get { return minMaxDamage; } set { value = minMaxDamage; } }
    private float damage;
    public float Damage { get { return Random.Range(MinMaxDamage.x, MinMaxDamage.y); } set { value = damage; } }
}

[System.Serializable]
public class FireDamage : OffenseImbue
{

}

[System.Serializable]
public class ColdDamage : OffenseImbue
{

}

[System.Serializable]
public class LightDamage : OffenseImbue
{

}

//*****************Defense
[System.Serializable]
public abstract class DefenseImbue : BaseImbue
{

    [Header("Damage")]
    [SerializeField]
    private Vector2 minMaxDamage;
    public Vector2 MinMaxDamage { get { return minMaxDamage; } set { value = minMaxDamage; } }
    private float damage;
    public float Damage { get { return Random.Range(MinMaxDamage.x, MinMaxDamage.y); } set { value = damage; } }
}

[System.Serializable]
public class FireRes : DefenseImbue
{

}

[System.Serializable]
public class ColdRes : DefenseImbue
{

}

[System.Serializable]
public class LightRes : DefenseImbue
{

}