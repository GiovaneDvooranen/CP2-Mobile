using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class DamageFlash : MonoBehaviour
{
    public Image image;

    public void Flash()
    {
        Debug.Log("FLASH CHAMADO");

        image.DOKill();

        Color c = image.color;
        c.a = 0.4f;

        image.color = c;

        image.DOFade(0f, 0.25f);
    }
}