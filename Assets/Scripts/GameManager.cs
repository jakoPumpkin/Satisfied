using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int points;
    public TextMeshProUGUI pointText;

    private void Start()
    {
        UpdateText();
    }

    public void UpdateText()
    {
        pointText.text = points.ToString();
    }
}
