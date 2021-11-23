using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AnimationStater : MonoBehaviour
{
    private Animator _animator;
    private static readonly int StateNum = Animator.StringToHash("StateNum");
    
    public void ChangeState()
    {
        int state = Random.Range(0, 3);
        _animator.SetInteger(StateNum, state);
    }

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
}
