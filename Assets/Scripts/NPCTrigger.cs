using UnityEngine;

public class NPCTrigger : MonoBehaviour
{
    public GameObject pressButtonCanvas; 
    public GameObject dialogueCanvas; 

    private Canvas currentCanvas;
    private bool playerInsideZone;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInsideZone = true;

            if (currentCanvas == null)
            {
                // Instantiate the first canvas at the same position as the trigger zone
                currentCanvas = Instantiate(pressButtonCanvas, transform.position, Quaternion.identity).GetComponent<Canvas>();
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInsideZone = false;

            // Destroy the current canvas when the player exits the trigger zone
            if (currentCanvas != null)
            {
                Destroy(currentCanvas.gameObject);
            }
        }
    }

    private void Update()
    {
        if (playerInsideZone && Input.GetKeyDown(KeyCode.E))
        {
            if (currentCanvas != null)
            {
                // Destroy the first canvas
                Destroy(currentCanvas.gameObject);

                // Instantiate the second canvas at the same position as the trigger zone
                currentCanvas = Instantiate(dialogueCanvas, transform.position, Quaternion.identity).GetComponent<Canvas>();
            }
        }
    }
}
