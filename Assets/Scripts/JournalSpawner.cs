using UnityEngine;

public class JournalSpawner : MonoBehaviour
{
    public GameObject journalCanvasPrefab;

    private Canvas currentJournalCanvas;
    private bool isJournalVisible = false;

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.J) || Input.GetKeyDown(KeyCode.Tab))
        {
            if (isJournalVisible)
            {
                
                DestroyJournalCanvas();
            }
            else
            {
                
                InstantiateJournalCanvas();
            }
        }
    }

    private void InstantiateJournalCanvas()
    {
        // Instantiate the journal canvas at the player's position
        currentJournalCanvas = Instantiate(journalCanvasPrefab, transform.position, Quaternion.identity).GetComponent<Canvas>();
        isJournalVisible = true;
    }

    private void DestroyJournalCanvas()
    {
        if (currentJournalCanvas != null)
        {
           
            Destroy(currentJournalCanvas.gameObject);
            isJournalVisible = false;
        }
    }
}
