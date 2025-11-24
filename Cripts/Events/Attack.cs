using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Attack : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    protected abstract IEnumerator SpawnObjects();


}
