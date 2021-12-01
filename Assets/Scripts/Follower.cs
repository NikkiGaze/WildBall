using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private Transform _originTransform;

    void Update()
    {
        if (_originTransform)
        {
            transform.position = _originTransform.position;
        }
    }
}
