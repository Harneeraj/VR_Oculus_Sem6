using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI status;

    public int Counter;

    private void Start()
    {
        Counter = 0;
    }

    private void Update()
    {
        status.text = Counter.ToString();
    }
}
