using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ButtonTrigger : MonoBehaviour
{
    [SerializeField] private LevelHUD _HUD;
    [SerializeField] private UnityEvent _onButtonClicked;

    private bool _isPressed = false;
    private void OnTriggerEnter(Collider other)
    {
        
        PlayerController player;
        if (!_isPressed && TryGetComponent(out player))
        {
            _HUD.ShowOpenButton(OnButtonPressed);
        }
    }

    private void OnButtonPressed()
    {
        _onButtonClicked.Invoke();
        _isPressed = true;
    }
}
