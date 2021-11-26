using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerMovement : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;

    private Vector3 _playerOffset;
    private void Start()
    {
        _playerOffset = transform.position - _playerTransform.position;
    }

    private void FixedUpdate()
    {
        transform.position = _playerTransform.position + _playerOffset;
    }
}
