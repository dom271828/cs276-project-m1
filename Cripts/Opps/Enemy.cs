using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Enemy : MonoBehaviour
{
    void Update()
        {
            Attack();
        }
    
    protected abstract void Attack();
}
