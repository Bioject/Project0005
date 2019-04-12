using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseItem : ScriptableObject {

    [SerializeField]
    private new string name;
    public string Name { get { return name; } set { name = value; } }
    [Tooltip("The value at which an item is sold by")]
    [SerializeField]
    private int m_value;
    public int Value { get { return m_value; } set { value = m_value; } }
    [SerializeField]
    private int weight;
    public int Weight { get { return weight; } set { weight = value; } }

    public abstract void Sell();
    public abstract void Buy();
    public abstract void Drop();
}
