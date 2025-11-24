using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreUI;

    int score = 0;
    public void UpdateScore(int amount)
    {
        score += amount;
        scoreUI.text = "Score:" + score.ToString();
    }
}
