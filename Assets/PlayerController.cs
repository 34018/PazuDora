// PlayerController.cs
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float bulletSpeed = 10f;
    public Text scoreText;
    public GameObject gameOverPanel;
    private int score = 0;
    private bool isGameOver = false;

    void Start()
    {
        UpdateScore();
        gameOverPanel.SetActive(false);
    }

    void Update()
    {
        if (isGameOver) return;

        // Player Movement
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveX, moveY, 0) * speed * Time.deltaTime;
        transform.position += move;

        // Shooting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.velocity = Vector2.up * bulletSpeed;
        }
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverPanel.SetActive(true);
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
            Debug.Log("GameOverPanel がアクティブになりました！"); // 追加
        }
        else
        {
            Debug.LogError("gameOverPanel が設定されていません！"); // エラーメッセージ
        }
    }
}