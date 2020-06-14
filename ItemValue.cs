using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemValue : MonoBehaviour
{
    private Score score;
    //Money value must be minus (because the function is calculated in "Cost"
    public int moneyValue;

    void Awake()
    {
        score = GameObject.Find("ScoreTracker").GetComponent<Score>();
    }
    public void AddValue()
    {
        Debug.Log("ADDED");
        score.UpdateScore(0, 0, 0, 0, 0, -moneyValue);
        Destroy(this.gameObject);
    }
}
