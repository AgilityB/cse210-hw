using System;

public class Word
{
    // =========================
    // Private Member Variables
    // =========================
    private string _text;
    private bool _isHidden;

    // =========================
    // Constructor
    // =========================
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // =========================
    // Hide the word
    // =========================
    public void Hide()
    {
        _isHidden = true;
    }

    // =========================
    // Show the word
    // =========================
    public void Show()
    {
        _isHidden = false;
    }

    // =========================
    // Check hidden state
    // =========================
    public bool IsHidden()
    {
        return _isHidden;
    }

    // =========================
    // Display text or underscores
    // =========================
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}