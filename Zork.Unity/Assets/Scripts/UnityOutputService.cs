using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using Zork;
using TMPro;
public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    [Range(10, 500)]
    private int MaxEntries = 60;

    [SerializeField]
    private Transform OutputTextContainer;

    [SerializeField]
    private TextMeshProUGUI TextLinePrefab;

    [SerializeField]
    private Image NewLinePrefab;

    public UnityOutputService()
    {
        _entries = new List<GameObject>(MaxEntries);
    }

    public void WriteLine(object value, bool isBold = false) => WriteLine(value.ToString(), isBold);

    public void WriteLine(string value, bool isBold = false)
    {
        var lines = value.Split(LineDelimiters, StringSplitOptions.None);
        foreach (var line in lines)
        {
            if(_entries.Count >= MaxEntries)
            {
                var entry = _entries.First();
                Destroy(entry);
                _entries.Remove(entry);
            }

            if (string.IsNullOrWhiteSpace(line))
            {
                WriteNewLine();
            }
            else
            {
                WriteTextLine(line, isBold);
            }
        }
    }
    public void Write(string value) => WriteLine(value);

    public void Write(object value) => WriteLine(value.ToString());

    private void WriteTextLine(string value, bool isBold = false)
    {
        var textLine = Instantiate(TextLinePrefab, OutputTextContainer);
        textLine.text = value;
        if(isBold)
        {
            textLine.fontStyle = FontStyles.Bold;
        }
        _entries.Add(textLine.gameObject);
    }

    private void WriteNewLine()
    {
        var newLine = Instantiate(NewLinePrefab, OutputTextContainer);
        _entries.Add(newLine.gameObject);
    }

    private static readonly string[] LineDelimiters = { "\n" };

    private readonly List<GameObject> _entries;
}
