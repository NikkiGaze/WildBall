using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ButtonTrigger : MonoBehaviour
{
    [SerializeField] private LevelHUD _HUD;
    [SerializeField] private UnityEvent _onButtonClicked;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null)
        {
            _HUD.ShowOpenButton(OnButtonPressed);
        }
    }

    private void OnButtonPressed()
    {
        _onButtonClicked.Invoke();
    }
}
