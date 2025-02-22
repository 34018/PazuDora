using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int scoreValue = 10;
    public float lifeTime = 5f; // 弾が消えるまでの時間（秒）

    void Start()
    {
        // 一定時間後に自動的に削除
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // スコア加算
            PlayerController player = FindObjectOfType<PlayerController>();
            if (player != null)
            {
                player.AddScore(scoreValue);
            }

            Destroy(other.gameObject); // 敵を消す
            Destroy(gameObject); // 弾も消す
        }
    }
}
