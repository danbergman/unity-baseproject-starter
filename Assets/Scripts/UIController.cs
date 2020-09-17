using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;    // singleton
    public Image heart1, heart2, heart3;
    public Sprite heartFull, heartHalf, heartEmpty;
    public Text gemText;

    public Image fadeScreen;
    public float fadeSpeed;
    public bool shouldFadeToBlack, shouldFadeFromBlack;

    public GameObject levelCompleteText;

    private void Awake() // like constructor function
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        FadeFromBlack();
        //UpdateGemCount();
    }

    // Update is called once per frame
    void Update()
    {

        if (shouldFadeToBlack)
        {

            fadeScreen.color = new Color(
                fadeScreen.color.r,
                fadeScreen.color.g,
                fadeScreen.color.b,
                Mathf.MoveTowards(fadeScreen.color.a, 1f, fadeSpeed * Time.deltaTime)     // 3rd of a second to get there.  Make fade consistent FPS.
                );

            if (fadeScreen.color.a == 1f)
            {
                shouldFadeToBlack = false;
            }
        }

        if (shouldFadeFromBlack)
        {

            fadeScreen.color = new Color(
            fadeScreen.color.r,
            fadeScreen.color.g,
            fadeScreen.color.b,
            Mathf.MoveTowards(fadeScreen.color.a, 0f, fadeSpeed * Time.deltaTime)     // 3rd of a second to get there.  Make fade consistent FPS.
            );

            if (fadeScreen.color.a == 0f)
            {
                shouldFadeFromBlack = false;
             // fadeScreen.
            }
        }

    }

    public void UpdateHealthDisplay()
    {

    }

    public void UpdateGemCount()
    {
        // gemText.text = LevelManager.instance.gemsCollected.ToString();
    }
    public void FadeToBlack()
    {
        shouldFadeToBlack = true;
        shouldFadeFromBlack = false;
    }
    public void FadeFromBlack()
    {
        shouldFadeToBlack = false;
        shouldFadeFromBlack = true;
    }

}

