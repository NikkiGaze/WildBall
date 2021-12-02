using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishProcessor : MonoBehaviour
{
    [SerializeField] private LevelHUD _HUD;
    private void OnTriggerEnter(Collider other)
    {
        PlayerController player;
        if (TryGetComponent(out player))
        {
            player.Kill(false);
            _HUD.FinishLevel();
        }
    }
}
