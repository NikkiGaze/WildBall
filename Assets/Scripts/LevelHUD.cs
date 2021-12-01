using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelHUD : MonoBehaviour
{
    [SerializeField] private SceneAsset _mainMenuScene;
    
    [SerializeField] private GameObject _restartButton;
    [SerializeField] private GameObject _menuButton;
    [SerializeField] private GameObject _nextButton;
    [SerializeField] private GameObject _openButton;
    [SerializeField] private GameObject _pauseButton;
    
    [SerializeField] private GameObject _deathText;
    
    private bool _isPaused;
    private int _nextSceneIndex;

    public void Start()
    {
        _isPaused = false;
        Time.timeScale = 1;
        _nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void OnPausePressed()
    {
        _isPaused = !_isPaused;
        _restartButton.SetActive(_isPaused);
        _menuButton.SetActive(_isPaused);
        Time.timeScale = _isPaused ? 0 : 1;
    }
    
    public void OnRestartPressed()
    {
        RestartLevel();
    }
    
    public void OnMainMenuPressed()
    {
        SceneManager.LoadScene(_mainMenuScene.name);
    }
    
    public void OnNextLevelPressed()
    {
        SceneManager.LoadScene(_nextSceneIndex);
    }
    
    public void KillPlayer()
    {
        _deathText.SetActive(true);
        _restartButton.SetActive(true);
        _menuButton.SetActive(true);
        _pauseButton.SetActive(false);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void FinishLevel()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        bool isLast = _nextSceneIndex == SceneManager.sceneCountInBuildSettings;
        if (isLast)
        {
            _restartButton.SetActive(true);
            _menuButton.SetActive(true);
            _pauseButton.SetActive(false);
        }
        else
        {
            _restartButton.SetActive(true);
            _menuButton.SetActive(true);
            _pauseButton.SetActive(false);
            _nextButton.SetActive(true);
        }
    }

    public void ShowOpenButton(UnityAction call)
    {
        _openButton.SetActive(true);
        _openButton.GetComponent<Button>().onClick.AddListener(call);
    }
}
