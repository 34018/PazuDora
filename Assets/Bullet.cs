using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int scoreValue = 10;
    public float lifeTime = 5f; // �e��������܂ł̎��ԁi�b�j

    void Start()
    {
        // ��莞�Ԍ�Ɏ����I�ɍ폜
        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            // �X�R�A���Z
            PlayerController player = FindObjectOfType<PlayerController>();
            if (player != null)
            {
                player.AddScore(scoreValue);
            }

            Destroy(other.gameObject); // �G������
            Destroy(gameObject); // �e������
        }
    }
}
