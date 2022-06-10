using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PitWinGroundScript : MonoBehaviour
{
    [SerializeField] GameObject HorizontalObstacle;
    [SerializeField] ScriptableObstacle _scriptableObs;
    [SerializeField] GameObject playerScript;
    PlayerScript player;


    private void Awake()
    {
        player = playerScript.GetComponent<PlayerScript>();
    }


    public void OnEnable()
    {

        Vector3 groundPos = _scriptableObs.winGroundPos;
        Vector3 obsPos = _scriptableObs.obstaclePos;

        transform.DOLocalMove(groundPos, 1f);

        HorizontalObstacle.transform.DOLocalMove(obsPos, 1f);

        if (!player.gameOver)
        {
            Invoke("PlayerMoveOn", 2f);
        }

    }


    void PlayerMoveOn()
    {
        player.moveOn = true;

    }
}
