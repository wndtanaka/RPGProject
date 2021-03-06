﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float currentHealthPoints = 100f ;
    [SerializeField]
    float maxHealthPoints = 100f;

    public float healthAsPercentage
    {
        get { return currentHealthPoints / (float)maxHealthPoints; }
    }
}
