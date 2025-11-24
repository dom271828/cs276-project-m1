using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HorizontalAttack : Attack
{
    // private IEnumerator coroutine;
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] float spawnAmount;
    private float waitTime = 2f;

    protected override IEnumerator SpawnObjects()
    {
        for (int i = 0; i < spawnAmount; i = i + 1)
        {
        yield return new WaitForSeconds(1f);
        Instantiate(obstaclePrefab, new Vector2(-16f, Random.Range(-9f, 9f)), Quaternion.identity);
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}