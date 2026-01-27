using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count <= numberToHide)
        {
            foreach (var word in visibleWords)
            {
                word.Hide();
            }
            return;
        }

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string refText = _reference.GetDisplayText();
        
        string content = "";
        foreach (Word word in _words)
        {
            content += word.GetDisplayText() + " ";
        }

        return $"{refText} {content.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        // If all words are hidden, return true
        return _words.All(w => w.IsHidden());
    }
}