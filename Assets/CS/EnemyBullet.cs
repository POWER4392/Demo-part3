using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float flySpeed = 10f;
    public int damage = 1;
    public float lifeTime = 2f; 

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {

        transform.Translate(Vector2.right * flySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        var enemy = collision.GetComponent<EnemyScript>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject); 
            return;
        }

        if (collision.CompareTag("Ground") || collision.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}