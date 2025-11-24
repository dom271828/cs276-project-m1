using UnityEngine;

public class VerticalEnemy : Enemy
{
    [SerializeField] float moveSpeed = 10f;
    private float timer = 0.0f;
    private float WaitTime = 16f;

    void Start()
    {

    }

    protected override void Attack()
    {
        transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
        if (timer > (WaitTime / (moveSpeed / 2.5f)))
        {
            Destroy(gameObject);
        }
    }
}
