using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HorizontalEnemy : Enemy
{
    [SerializeField] float moveSpeed = 20f;
    private float timer = 0.0f;
    private float WaitTime = 16f;
    // Update is called once per frame
    void Start()
    {
        WaitTime = moveSpeed / 2.5f;
        Debug.Log(WaitTime);
    }

    protected override void Attack()
    {
        transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        if (timer > WaitTime)
        {
            Destroy(gameObject);
        }
        
        timer += Time.deltaTime;
    }
}
