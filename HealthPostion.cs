using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewHealth", menuName = "Inventory/Health")]

public class HealthPotion : Item 
{
    public int HealthModifier;
    CharacterStats Charstats;
    void start()
    {
        Charstats = CharacterStats.instance;
    }

    public override void Use()
    {
        base.Use();
        ApplyEffect();
    }
    public void ApplyEffect()
    {
        CharacterStats.instance.ModifiyHealth(HealthModifier);
     }
}
