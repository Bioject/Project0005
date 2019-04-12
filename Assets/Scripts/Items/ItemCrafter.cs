using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item Crafter", menuName = "Items/Potion Crafter")]
public class ItemCrafter : ScriptableObject
{

    public List<Combination> combinations = new List<Combination>();
}

[System.Serializable]
public class Combination
{
    [Header("Crafting")]
    [Tooltip("Items to be crafted")]
    [SerializeField]
    private List<BasePotion> craftItems;
    [Space(5)]
    [Header("Results")]
    [Tooltip("The result from the crafting the items")]
    [SerializeField]
    private BasePotion itemResult;

    //Store the items you want to be crafted into a list and than pass them through the parameters of this method
    public BasePotion AttemptCraft(List<BasePotion> potions)//this method will evaluate what is passed though and see if it can be crafted
    {
        if (potions.Count != craftItems.Count)
            return null;

        //counting the times the cominations matched
        int count = 0;
        for (int i = 0; i < craftItems.Count; i++)
        {
            if (craftItems[i] == potions[i])
            {
                count++;
                if (count >= potions.Count)
                    return itemResult;
            }//end of if
        }//end f forloop
        return null;
    }//end of Craft()
}//end of class
