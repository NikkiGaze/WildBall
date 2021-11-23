using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHUD : MonoBehaviour
{
    [SerializeField] private SceneAsset _mainMenuScene;
    [SerializeField] private GameObject _restartButton;
    [SerializeField] private GameObject _menuButton;

    private bool isPaused = false;
    public void OnPausePressed()
    {
        isPaused = !isPaused;
        _restartButton.SetActive(isPaused);
        _menuButton.SetActive(isPaused);
    }
    
    public void OnRestartPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void OnMainMenuPressed()
    {
        SceneManager.LoadScene(_mainMenuScene.name);
    }
}
