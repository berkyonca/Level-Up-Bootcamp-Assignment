using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CollectableTriggerScript : MonoBehaviour
{
    // Player Objesi
    [SerializeField] GameObject winGround;
    [SerializeField] TextMeshPro textPro;
    [SerializeField] ScriptablePit _scriptablePit;
    [SerializeField] ScriptableScore _scriptableScore;


    int pitBalls = 0;
   
    private void Awake()
    {
        int pitBalls = _scriptablePit.pitBall;
        int score = _scriptableScore.Score = 0;
    }

    private void Update()
    {
        if (pitBalls >= 20)
        {
            winGround.SetActive(true);
        }
        textPro.text = pitBalls.ToString() + "/ 20";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("collectable"))
        {
            pitBalls++;
            _scriptableScore.Score++;
        }
    }


}
