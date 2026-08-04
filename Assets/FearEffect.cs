using UnityEngine;
using UnityEngine.UI;

public class FearEffect : MonoBehaviour
{
    public Image overlay;

    public void UpdateFear(int stressLevel)
    {
        float alpha = stressLevel / 20f;

        Color color = overlay.color;
        color.a = alpha;

        overlay.color = color;
    }
}