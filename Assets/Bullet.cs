using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int scoreValue = 10;
    public float lifeTime = 5f; // ’e‚ªÁ‚¦‚é‚Ü‚Å‚ÌŠÔi•bj

    void Start()
    {
        // ˆê’èŠÔŒã‚É©“®“I‚Éíœ
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // ƒXƒRƒA‰ÁZ
            PlayerController player = FindObjectOfType<PlayerController>();
            if (player != null)
            {
                player.AddScore(scoreValue);
            }

            Destroy(other.gameObject); // “G‚ğÁ‚·
            Destroy(gameObject); // ’e‚àÁ‚·
        }
    }
}
