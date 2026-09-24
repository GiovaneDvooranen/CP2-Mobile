using TMPro;
using UnityEngine;

public class UIHealth : MonoBehaviour
{
    public TextMeshProUGUI text;
    public PlayerHealth player;

    void Update()
    {
        text.text = "Vida: " + player.GetHealth() + "\nEscudo: " + player.GetShield();
    }
}