using UnityEngine;
using DG.Tweening;

public class EnemyHealth : MonoBehaviour
{
    private Vector3 originalScale;
    public int hp = 50;

    public int scoreValue = 10;

    private Renderer rend;
    private Color originalColor;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        originalScale = transform.localScale;
        originalColor = rend.material.color;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;

        PlayHitEffect();

        if (hp <= 0)
        {
            ScoreManager.Instance.AddScore(scoreValue);

            Destroy(gameObject);
        }
    }

    private void PlayHitEffect()
    {
        transform.DOKill();

        if (rend != null)
            rend.material.DOKill();

        transform.DOPunchScale( Vector3.one * 0.4f, 0.2f, 5, 0.5f);

        Sequence seq = DOTween.Sequence();

        seq.Append(rend.material.DOColor(Color.red, 0.05f));

        seq.Append(rend.material.DOColor(originalColor, 0.05f));
    }

    private void OnDestroy()
    {
        transform.DOKill();

        if (rend != null)
            rend.material.DOKill();
    }

}