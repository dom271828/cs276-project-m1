using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpreadAttack : Attack
{
    // private IEnumerator coroutine;
    [SerializeField] GameObject obstaclePrefab;
    
    [SerializeField] float spawnAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float waitTime = 2f;

    protected override IEnumerator SpawnObjects()
    {
        for (int i = 0; i < spawnAmount; i = i + 1)
        {
        yield return new WaitForSeconds(1f);
        Instantiate(obstaclePrefab, new Vector2(Random.Range(-17f, 17f), Random.Range(-8f, 8f)), Quaternion.identity);
        }

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
