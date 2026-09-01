using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] TMP_Text num;
    int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        num.text = score.ToString();
    }

    public void IncreaseCounter()
    {
        score += 1;
        num.text = score.ToString();
    }
}
