using System;
using System.Collections.Generic;

public class Scripture
{
    // =========================================================
    // ENCAPSULATION
    // All member variables are private.
    // =========================================================

    private Reference _reference;
    private List<Word> _words;

    // Better random usage
    private Random _random = new Random();

    // =========================================================
    // Constructor
    // =========================================================

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = new List<Word>();

        // Split scripture text into words
        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    // =========================================================
    // Hide random words
    // =========================================================

    public void HideRandomWords(int numberToHide)
    {
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = _random.Next(_words.Count);

            // Only hide words that are not hidden
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }

            // Stop if all words are hidden
            if (IsCompletelyHidden())
            {
                break;
            }
        }
    }

    // =========================================================
    // Return scripture display text
    // =========================================================

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();
    }

    // =========================================================
    // Check if all words are hidden
    // =========================================================

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