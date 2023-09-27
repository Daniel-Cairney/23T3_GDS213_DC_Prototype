using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour
{
    // Public variables to specify the scene to load and the spawn position
    public string sceneToLoad;
    public Vector2 spawnPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter Door");

        // Save the desired spawn position in a PlayerPrefs or another method of your choice
        PlayerPrefs.SetFloat("SpawnX", spawnPosition.x);
        PlayerPrefs.SetFloat("SpawnY", spawnPosition.y);

        // Load the specified scene
        SceneManager.LoadScene(sceneToLoad);
    }
}
