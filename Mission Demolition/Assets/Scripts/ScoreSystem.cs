using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    static public ScoreSystem S;
    public Text gtScore;
    public int totalScore;

    private void Start()
    {
        S = this;
        gtScore = S.GetComponent<Text>();
        gtScore.text = "Score: " + totalScore;
    }

    private void Update()
    {
        gtScore.text = "Score: " + totalScore;
    }

}
