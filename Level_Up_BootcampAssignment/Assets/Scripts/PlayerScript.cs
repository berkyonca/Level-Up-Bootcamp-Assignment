using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerScript : MonoBehaviour
{
    public ScriptablePlayer _Scriptable;
    [SerializeField] GameObject gameOverButton;
    [SerializeField] GameObject finishObject;

    public bool moveOn = true;
    public bool gameOver = false;

    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        if (moveOn && !gameOver)
        {
            PlayerMovement();
        }
        if (gameOver)
        {
            GameOver();
        }

    }


    void PlayerMovement()
    {
        rb.velocity = Vector3.forward * _Scriptable.verticalSpeed;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * Time.deltaTime * _Scriptable.horizontalSpeed);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * Time.deltaTime * _Scriptable.horizontalSpeed);
        }
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnterTrigger"))
        {
            moveOn = false;
            StartCoroutine(GameOverTime());
        }
        if (other.gameObject.CompareTag("FinishTrigger"))
        {
            moveOn = false;
            gameOver = true;

        }

    }

    IEnumerator GameOverTime()
    {
        yield return new WaitForSeconds(5.5f);
        if (moveOn == false)
        {
            gameOver = true;
        }


    }

    void GameOver()
    {
        gameOverButton.SetActive(true);
        finishObject.GetComponent<TryAgainScript>().enabled = true;

    }





}
