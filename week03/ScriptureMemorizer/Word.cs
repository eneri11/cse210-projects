public class Word
{
    // =========================================================
    // ENCAPSULATION
    // All member variables are private.
    // =========================================================

    private string _text;
    private bool _isHidden;

    // =========================================================
    // Constructor
    // =========================================================

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // =========================================================
    // Hide the word
    // =========================================================

    public void Hide()
    {
        _isHidden = true;
    }

    // =========================================================
    // Show the word
    // =========================================================

    public void Show()
    {
        _isHidden = false;
    }

    // =========================================================
    // Check if word is hidden
    // =========================================================

    public bool IsHidden()
    {
        return _isHidden;
    }

    // =========================================================
    // Return word or underscores
    // =========================================================

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
