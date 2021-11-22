using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelNamer : MonoBehaviour
{
    [SerializeField] private Text _name;
    
    public void SetName(string name)
    {
        _name.text = name;
    }

}
