using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }
    [SerializeField] float currentSpeed = 10f;
    [SerializeField] float steerSpeed = 1f;
    
    private float cooldownTime = 1f;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision)
    {
    Destroy(gameObject);
    }
    void Update()
    {

        float move = 0f;
        float steer = 0f;
        cooldownTime += Time.deltaTime;

        MovePlayer();

        // float moveAmount = move * currentSpeed * Time.deltaTime;
        // float steerAmount = steer * steerSpeed * Time.deltaTime;

        // transform.Translate(0, moveAmount, 0);
        // transform.Rotate(0, 0, steerAmount);
    
    }

    public void MovePlayer()
    {
        
        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            transform.Translate(0, currentSpeed * Time.deltaTime, 0);
        }

        else if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            transform.Translate(0, -currentSpeed * Time.deltaTime, 0);
        }

        if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Translate(-currentSpeed * Time.deltaTime, 0, 0);
        }

        else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
        }

        cooldownTime = 0;
    }
}
