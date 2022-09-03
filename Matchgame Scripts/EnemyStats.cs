using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public EnemyData enemy;

    private void Start()
    {
        Debug.Log(enemy.name);
    }
}
