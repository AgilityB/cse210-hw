using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    // =========================
    // Private Member Variables
    // =========================
    private Reference _reference;
    private List<Word> _words;

    // =========================
    // Constructor
    // =========================
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());
        Console.WriteLine();

        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }

        Console.WriteLine();
    }

    // =========================
    // Hiding Random Words 
    // =========================
    public void HideRandomWords(int count, Random random)
    {
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    // =========================
    // Check Completion
    // =========================
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
