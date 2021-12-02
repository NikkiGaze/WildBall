using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    [SerializeField] private Transform _originTransform;

    private void Update()
    {
        if (_originTransform)
        {
            transform.position = _originTransform.position;
        }
    }
}
