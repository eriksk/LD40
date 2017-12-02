
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ProgressBar : MonoBehaviour
{
    [Range(0f, 1f)]
    public float Value;
    public float MaxWidth;
    public Image ProgressImage;

    void Update()
    {
        if(ProgressImage == null) return;

        ProgressImage.rectTransform.sizeDelta = new Vector2(
            MaxWidth * Value,
            ProgressImage.rectTransform.sizeDelta.y
        );
    }
}