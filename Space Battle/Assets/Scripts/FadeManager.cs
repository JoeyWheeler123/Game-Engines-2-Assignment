using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FadeManager : MonoBehaviour
{
    public static FadeManager Instance { set; get; }

    public Image image;
    private bool isFading;
    private float fade;
    private bool isFaded;
    private float time;

    private void Awake()
    {
        Instance = this;
    }

    public void Fade(bool fading, float time)
    {
        isFaded = fading;
        isFading = true;
        this.time = time;
        fade = (isFaded) ? 0 : 1;
    }

    private void Update()
    {
        /*if(Input.GetKey(KeyCode.A))
        {
            Fade(true, 1.25f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Fade(false, 1.25f);
        }*/

        if (!isFading)
        {
            return;
        }

        fade += (isFaded) ? Time.deltaTime * (1 / time) : -Time.deltaTime * (1 / time);
        image.color = Color.Lerp(new Color(1, 1, 1, 0), Color.black, fade);

        if(fade > 1 || fade < 0)
        {
            isFading = false;
        }
    }
}
