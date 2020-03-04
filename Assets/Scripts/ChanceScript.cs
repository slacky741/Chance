using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChanceScript : MonoBehaviour
{
    int MinNumber;
    int MaxNumber;
    public InputField Minimum;
    public InputField Maximum;
    public Text txt;
    public Button start;

    void Start()
    {
        Button btn = start.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {

        MinNumber = int.Parse(Minimum.text);
        MaxNumber = int.Parse(Maximum.text);
        int randomNumber = Random.Range(MinNumber, MaxNumber);
        txt.text = randomNumber.ToString();
    }
    void Update()
    {

    }
}

