using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Weapon Item")]
public class WeaponItem : Item
{
    public GameObject modelPrefab;
    public bool isUnarmed;
    //added episode 13
    [Header("Idle Animations")]
    public string right_Hand_Idle;
    public string left_Hand_Idle;
    /*added episode 9*/
    [Header("One Handed Attack Animations")]
    public string OH_Light_Attack_1;
    public string OH_Light_Attack_2;
    public string OH_Light_Attack_3;
    public string OH_Heavy_Attack_1;

//added episode 16
    [Header("Stamina Costs")]
    public int baseStamina;
    public float lightAttackMultiplier;
    public float heavyAttackMultiplier;
    // [Header("two Handed Attack Animations")]
}