using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Text _headerText;
    [SerializeField] private GameObject _playButton;
    [SerializeField] private GameObject _backButton;
    [SerializeField] private GameObject _levelsPanel;
    
    [SerializeField] private GameObject _levelPrefab;
    [SerializeField] private List<SceneAsset> _levelsList;
    private void Start()
    {
        foreach (Transform child in _levelsPanel.transform)
        {
            Destroy(child.gameObject);
        }

        int levelNum = 1;
        foreach (var scene in _levelsList)
        {
            GameObject levelButton = Instantiate(_levelPrefab, _levelsPanel.transform);
            levelButton.GetComponent<LevelNamer>().SetName(levelNum.ToString());
            
            levelButton.GetComponent<Button>().onClick.AddListener(() => OnLevelClicked(scene.name));
            levelNum++;
        }
    }

    public void OnPlayClicked()
    {
        _playButton.SetActive(false);
        
        _levelsPanel.SetActive(true);
        _backButton.SetActive(true);
        _headerText.text = "select level";
    }

    public void OnBackClicked()
    {
        _backButton.SetActive(false);
        
        _levelsPanel.SetActive(false);
        _playButton.SetActive(true);
        _headerText.text = "wild ball";
    }
    
    private void OnLevelClicked(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
