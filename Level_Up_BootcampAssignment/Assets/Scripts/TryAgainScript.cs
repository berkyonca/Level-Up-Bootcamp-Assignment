using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class TryAgainScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _highScore;
    [SerializeField] ScriptableScore _scriptableScore;
    private void Start()
    {

        if (_scriptableScore.Score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", _scriptableScore.Score);
            _highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();

        }
        else
        {
            _highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
        }


    }
    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
