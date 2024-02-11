using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verseEnd;

    public Reference (string book, int chapter, int verseStart, int verseEnd)
    {
    _book = book;
    _chapter = chapter;
    _verse = verseStart;
    _verseEnd = verseEnd;
    }

    public Reference (string book, int chapter, int verseStart)
    {
    _book = book;
    _chapter = chapter;
    _verse = verseStart;
    }

    public string GetText()
    {
        return $"{_book} {_chapter}:{_verse}-{_verseEnd}";
    }
}