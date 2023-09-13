using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Click : MonoBehaviour
{
    public float firstTextDelay = 2f;              // Delay before displaying the first text.
    public float firstTextDuration = 500f;           // Duration of the first text display.
    public float secondTextDelay = 2f;             // Delay before displaying the second text.
    public float secondTextDuration = 300f;          // Duration of the second text display.
    public Text firstTextElement;                   // Reference to the first UI Text element.
    public Text secondTextElement;                  // Reference to the second UI Text element.
    
    private bool isDisplayingText = false;

    void Start()
    {
        // Set initial alpha to 0 for both text elements.
        SetAlpha(firstTextElement, 0f);
        SetAlpha(secondTextElement, 0f);

        // Start displaying the first text with a delay.
        Invoke("DisplayFirstTextWithDelay", firstTextDelay);
    }

    void DisplayFirstTextWithDelay()
    {
        // Set isDisplayingText to true to prevent further updates.
        isDisplayingText = true;

        // Display the first text with a fade-in effect.
        StartCoroutine(FadeInText(firstTextElement, firstTextDuration));

        // After the first text display duration, hide it and schedule the second text.
        Invoke("HideFirstText", firstTextDelay + firstTextDuration + secondTextDelay);
        Invoke("DisplaySecondTextWithDelay", firstTextDelay + firstTextDuration);
    }

    void HideFirstText()
    {
        // Hide the first text with a fade-out effect.
        StartCoroutine(FadeOutText(firstTextElement, firstTextDuration));
    }

    void DisplaySecondTextWithDelay()
    {
        // Display the second text with a fade-in effect.
        StartCoroutine(FadeInText(secondTextElement, secondTextDuration));

        // After the second text display duration, hide it.
        Invoke("HideSecondText", secondTextDuration);
    }

    void HideSecondText()
    {
        // Hide the second text with a fade-out effect.
        StartCoroutine(FadeOutText(secondTextElement, secondTextDuration));
        
        isDisplayingText = false;
    }

    void Update()
    {
        // You can add additional logic here if needed.
    }

    // Helper method to set the alpha of a Text component.
    private void SetAlpha(Text text, float alpha)
    {
        CanvasGroup canvasGroup = text.GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = text.gameObject.AddComponent<CanvasGroup>();
        }
        canvasGroup.alpha = alpha;
    }

    // Coroutine for fading in a Text component.
    private IEnumerator FadeInText(Text text, float duration)
    {
        CanvasGroup canvasGroup = text.GetComponent<CanvasGroup>();
        float timer = 0f;
        float startAlpha = canvasGroup.alpha;
        float targetAlpha = 1f;

        while (timer < duration)
        {
            timer += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, targetAlpha, timer / duration);
            yield return null;
        }

        canvasGroup.alpha = targetAlpha;
    }

    // Coroutine for fading out a Text component.
    private IEnumerator FadeOutText(Text text, float duration)
    {
        CanvasGroup canvasGroup = text.GetComponent<CanvasGroup>();
        float timer = 0f;
        float startAlpha = canvasGroup.alpha;
        float targetAlpha = 0f;

        while (timer < duration)
        {
            timer += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(startAlpha, targetAlpha, timer / duration);
            yield return null;
        }

        canvasGroup.alpha = targetAlpha;
    }
}
