using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Text : MonoBehaviour
{
    [SerializeField]
    private string _prefix;

    private TextMeshProUGUI _text;

    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    public void SetValue(string value)
    {
        _text.text = $"{_prefix}: {value}";
    }
}
