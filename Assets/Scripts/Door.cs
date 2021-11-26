using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject _doorMain;
    
    public void Open()
    {
        Destroy(_doorMain);
    }
}
