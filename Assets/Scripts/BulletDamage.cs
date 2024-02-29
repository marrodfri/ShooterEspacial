using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("ship"))
        {
            Destroy(gameObject);
        }
    }
}