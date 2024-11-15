using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RawImage))]
public class FadeBlack: MonoBehaviour
{
    RawImage blackOverlay;

    private void Start()
    {
        blackOverlay = gameObject.GetComponent<RawImage>();
    }

    // Cambiar porcentaje de negro en la pantalla
    public void ChangeVisibility(float percentage) // 0f - 1f
    {
        float alphaAmount = 255f * percentage;
        blackOverlay.color = new Color(255f,255f,255f, alphaAmount);
    }

}
