using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHandler : MonoBehaviour
{
    public bool alive;

    public int skillPoint;

    public float maxHealth;
    public float curHealth;
    public float maxMana;
    public float curMana;
    public float Defence;
    public float Attack;
    public float maxStam;
    public float curStam;
    public float Speed;    

    public int Vitality;
    public int Strength;
    public int Intelligence;
    public int Endurance;
    public int Dexterity;
    public int Resistance;

    private void Start()
    {
        // Character starts alive
        alive = true;
        // current health starts off at max health
        curHealth = maxHealth;
        // Vitality increases max health 
        maxHealth += Vitality * 3;
        // Strength increases attack
        Attack += Strength * 2;
        // Intelligence increases max mana
        maxMana += Intelligence * 3;
        // Endurance increases max stamina
        maxStam += Endurance * 2;
        // Dexterity increases max speed
        Speed += Dexterity * 1.5f;
        // Resistance increases max defence
        Defence += Resistance * 3;

    }
}
