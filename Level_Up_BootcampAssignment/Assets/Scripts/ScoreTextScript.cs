using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTextScript : MonoBehaviour
{
    [SerializeField] ScriptableScore _scriptableScore;
    [SerializeField] TextMeshProUGUI _scoreText;

    
    private void Update()
    {
        _scoreText.text = "Score :" + _scriptableScore.Score;
    }
}
