using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appearer : MonoBehaviour
{
    [SerializeField] private int _bonusesToAppear;
    [SerializeField] private GameObject _platform;
    [SerializeField] private ParticleSystem _particle;

    public void BonusDestroyed()
    {
        _bonusesToAppear--;
        if (_bonusesToAppear == 0)
        {
            _platform.SetActive(true);
            _particle.Play();
        }
    }
}
