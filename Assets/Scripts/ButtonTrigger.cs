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
        if (other.GetComponent<PlayerController>() != null && !_isPressed)
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
