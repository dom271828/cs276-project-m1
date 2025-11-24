using UnityEngine;

public class StaticEnemy : Enemy
{
    private float timer = 0.0f;
    private float WaitTime = 3f;

    protected override void Attack()
    {
        if (timer > WaitTime)
        {
            Destroy(gameObject);
        }

        timer += Time.deltaTime;
    }
}
