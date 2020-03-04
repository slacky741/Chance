using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinToss : MonoBehaviour
{
    public Text text;
    public Button start;

    void Start()
    {
        {
            Button btn = start.GetComponent<Button>();
            btn.onClick.AddListener(TaskOnClick);
        }
    }

    void TaskOnClick()
    {
        float randValue = Random.value;
        if (randValue < .50f) // 45% of the time
        {
            text.text = "Heads";
        }
        else
        {
            text.text = "Tails";
        }
    }
}
