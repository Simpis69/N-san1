using System;
using System.Reflection.Metadata.Ecma335;

namespace klasser;

class Book
{
    private int BPages;

    private string BName = "";

    public Book(String name,int pages)
    {
        BName = name;
        BPages = pages;
    }

    public string GetName()
    {
        return BName;
    }
    public int GetPages()
    {
        return BPages;
    }


    private int CurrentPage;

    public int GetCurrentPage()
    {
        return CurrentPage;
    }

    public int TurnPage;
}
