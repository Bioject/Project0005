using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGem : BaseItem {

    [SerializeField]
    private int level;
    public int Level { get { return level; } set { level = value; } }
    [SerializeField]
    private OffenseImbue imbue;
    public OffenseImbue Imbue { get { return imbue; } set { imbue = value; } }
}
