using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuControlScript : MonoBehaviour
{
    [SerializeField]
    Button _startButton;
    [SerializeField]
    Button _optionButton;
    [SerializeField]
    Button _exitButton;
    [SerializeField]
    Button _scoreButton;
    [SerializeField]
    Button _howtoplayButton;
    // Start is called before the first frame update
    void Start()
    {
        _startButton.onClick.AddListener(
            delegate { StartButtonClock(_startButton); });
        _optionButton.onClick.AddListener(
            delegate { OptionButtonClick(_optionButton); });
        _exitButton.onClick.AddListener(
            delegate { ExitButtonClick(_exitButton); });
        _scoreButton.onClick.AddListener(
            delegate { ScoreButtonClock(_scoreButton); });
        _howtoplayButton.onClick.AddListener(
            delegate { HowtoplayButtonClock(_howtoplayButton); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButtonClock(Button button)
    {
        SceneManager.LoadScene("SceneGameplay");
    }

    public void OptionButtonClick(Button button)
    {
        if(!GameApplicationMaganer.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("SceneOption", LoadSceneMode.Additive);
            GameApplicationMaganer.Instance.IsOptionMenuActive = true;
        }
    }
    public void ScoreButtonClock(Button button)
    {
        SceneManager.LoadScene("SceneScore");
    }
    public void HowtoplayButtonClock(Button button)
    {
        SceneManager.LoadScene("SceneHowtoplay");
    }


    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }
}
