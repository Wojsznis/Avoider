using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameOverHandler gameOverHandler;

    public void Crash()
    {
        gameOverHandler.EndGame();

        gameObject.SetActive(false);
    }
}
