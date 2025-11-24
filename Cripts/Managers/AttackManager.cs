using UnityEngine;
using System.Collections;

public class AttackManager : MonoBehaviour
{
    [SerializeField] GameObject spreadAttack;
    [SerializeField] GameObject sideAttack;
    [SerializeField] GameObject verticalAttack;
    private bool running = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(InitiateSequence());
    }

    // Update is called once per frame
    void Update()
    {
        if (running == true)
        {
            StartCoroutine(InitiateSequence());
        }
    }

    private IEnumerator InitiateSequence()
    {
        running = false;
        Instantiate(verticalAttack);
        yield return new WaitForSeconds(5f);
        Instantiate(sideAttack);
        yield return new WaitForSeconds(5f);
        Instantiate(spreadAttack);
        yield return new WaitForSeconds(10f);
        running = true;
    }
}
