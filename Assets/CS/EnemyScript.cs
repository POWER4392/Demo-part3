using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int maxHealth = 3; 
    int currentHealth;

    void Start()
    {
        currentHealth = maxHealth; 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       Debug.Log("CÓ CÁI GÌ ĐÓ CHẠM VÀO TÔI: " + other.gameObject.name);
        if (other.CompareTag("Bullet"))
        {
            TakeDamage(1); 
            Destroy(other.gameObject); 
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("Enemy bị bắn! Máu còn: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy đã chết!");
        Destroy(gameObject);
    }
}