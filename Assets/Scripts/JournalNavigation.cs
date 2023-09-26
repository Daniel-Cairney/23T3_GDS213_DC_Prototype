using UnityEngine;
using UnityEngine.UI;

public class JournalNavigation : MonoBehaviour
{
    public Image journalImage;
    public Sprite[] journalPages;

    private int currentPageIndex = 0;

    private void Start()
    {
        ShowPage(currentPageIndex);
    }

    public void NextPage()
    {
        if (currentPageIndex < journalPages.Length - 1)
        {
            currentPageIndex++;
            ShowPage(currentPageIndex);
        }
    }

    public void PreviousPage()
    {
        if (currentPageIndex > 0)
        {
            currentPageIndex--;
            ShowPage(currentPageIndex);
        }
    }

    private void ShowPage(int pageIndex)
    {
        if (pageIndex >= 0 && pageIndex < journalPages.Length)
        {
            journalImage.sprite = journalPages[pageIndex];
        }
    }
}
