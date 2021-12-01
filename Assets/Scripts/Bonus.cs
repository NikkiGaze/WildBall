using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private Appearer _platform;
    [SerializeField] private ParticleSystem _particle;
    [SerializeField] private GameObject _mesh;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            _particle.Play();
            Destroy(_mesh);
            _platform.BonusDestroyed();
        }
    }
}
