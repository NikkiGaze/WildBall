using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _movementParticle;
    [SerializeField] private ParticleSystem _deathParticle;
    [SerializeField] private ParticleSystem _winParticle;
    [SerializeField, Range(0, 10)] private float _speed;
    private Rigidbody _rigidBody;
    private Vector3 _movementVector;
    private bool _isDead;
    
    private const string HorizontalInput = "Horizontal";
    private const string VerticalInput = "Vertical";
    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis(HorizontalInput);
        float verticalInput = Input.GetAxis(VerticalInput);
        _movementVector = new Vector3(horizontalInput, 0, verticalInput).normalized * _speed;
    }
    
    private void FixedUpdate()
    {
        if (_isDead)
        {
            return;
        }
        _rigidBody.AddForce(_movementVector);
    }
    
    public void Kill(bool lost)
    {
        _movementParticle.Stop();

        if (lost)
        {
            _deathParticle.Play();
        }
        else
        {
            _winParticle.Play();
        }
        Destroy(gameObject);
    }
}

    