using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    [SerializeField] private LevelHUD _HUD;
    private void OnTriggerEnter(Collider other)
    {
        PlayerController player;
        if (TryGetComponent(out player))
        {
            player.Kill(true);
            _HUD.KillPlayer();
        }
    }
}
