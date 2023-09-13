using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene1Transition : MonoBehaviour
{
    public Image fadeImage; // Reference to a UI Image used for fading.
    public float fadeDuration = 1.0f; // Duration of the fade in seconds.
    public int sceneToLoad; // Index of Scene2 in the build settings.

    private bool isFading = false;

    public void StartSceneTransition()
    {
        if (!isFading)
        {
            StartCoroutine(Transition());
        }
    }

    private IEnumerator Transition()
    {
        isFading = true;

        // Create a fade-in effect by changing the alpha of the UI Image.
        float timer = 0f;
        Color startColor = fadeImage.color;
        Color endColor = new Color(startColor.r, startColor.g, startColor.b, 1f);

        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            fadeImage.color = Color.Lerp(startColor, endColor, timer / fadeDuration);
            yield return null;
        }

        // Load the next scene (Scene2) asynchronously.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad);

        // Wait until Scene2 is fully loaded.
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Create a fade-out effect.
        timer = 0f;
        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            fadeImage.color = Color.Lerp(endColor, startColor, timer / fadeDuration);
            yield return null;
        }

        isFading = false;
    }
}
