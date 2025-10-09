using UnityEngine;
using System;
using UnityEditor;
using UnityEngine.SceneManagement; // Required for scene management

public class SceneChange : MonoBehaviour
{
    // Method to change the scene by name
    public void ChangeScene(string sceneName)
    {
        // Check if the scene exists in the build settings
        if (Application.CanStreamedLevelBeLoaded(sceneName))
        {
            SceneManager.LoadScene(sceneName); // Load the specified scene
        }
        else
        {
            Debug.LogError($"Scene '{sceneName}' does not exist in Build Settings!");
        }
    }

    // Optional: Method to load the next scene in the build index
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        // Check if the next scene index is valid
        if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
        else
        {
            Debug.LogError("No more scenes to load!");
        }
    }
}