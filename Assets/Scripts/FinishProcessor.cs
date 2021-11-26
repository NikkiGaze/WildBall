﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishProcessor : MonoBehaviour
{
    [SerializeField] private LevelHUD _HUD;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            _HUD.FinishLevel();
        }
    }
}
