using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Type")]
public class EnemyData : ScriptableObject
{
    public int health;
    public int attack;
    public int defense;

    public new string name;
}
