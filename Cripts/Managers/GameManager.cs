using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] PlayerController playerController;
    [SerializeField] GameObject restartButton;
    [SerializeField] Button restartButtonUI;
    float timeElapsed = 0f;
    float score = 0f;
    bool playerOut = false;
    private float timer = 0.0f;
    private float WaitTime = 2f;

    void Start()
    {
        
    }


    void Update()
    {
        CheckScore();
        CheckStatus();
    }

    void CheckScore()
    {
        if (playerOut) return;

        timer += Time.deltaTime; 
        if (timer < WaitTime) return;

        scoreManager.UpdateScore(100);
        timer = 0f;
    }

    void CheckStatus()
    {
        if (playerController != null) return;
        
        playerOut = true;
        restartButton.SetActive(true);

        if (Keyboard.current.spaceKey.isPressed)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
