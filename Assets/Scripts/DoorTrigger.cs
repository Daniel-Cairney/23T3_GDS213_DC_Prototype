using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour
{
    // Public variable to specify the scene to load
    public string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter Door");

        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
