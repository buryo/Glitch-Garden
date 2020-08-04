using System;
using System.Collections;
using UnityEngine.SceneManagement;

public static class LevelLoader
{
    private static Action onLoaderCallback;

    public enum Scene
    {
        StartScreen,
        SplashScreen,
        GameScreen
    }

    public static void Load(Scene scene)
    {
        // Set the loader callback action to load the target scene.
        onLoaderCallback = () =>
        {
            SceneManager.LoadScene(scene.ToString());
        };

        // Load the loading scene.
        SceneManager.LoadScene(Scene.SplashScreen.ToString());
    }

    public static void LoaderCallback()
    {
        // Triggered after the first Update which lets the screen refresh.
        // Execute the loader callback action which will load the target scene.
        if (onLoaderCallback != null)
        {
            onLoaderCallback();
            onLoaderCallback = null;
        }
    }
}