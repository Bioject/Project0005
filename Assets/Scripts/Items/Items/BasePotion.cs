using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePotion : BaseItem {

    [Tooltip("Amount by which the potion increases the value of something by")]
    [SerializeField]
    private int amount;
    public int Amount { get { return amount; } set { value = amount; } }
    public enum PotionType { Health, Mana, Stamina, Powerup };
    [SerializeField]
    private PotionType type;
    public PotionType Type { get { return type; } set { type = value; } }
    public enum PotionSize { Small, Medium, Large};
    [SerializeField]
    private PotionSize size;
    public PotionSize Size { get { return size; } set { size = value; } }

    public abstract void Use();
}
