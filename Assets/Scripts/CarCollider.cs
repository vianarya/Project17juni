using UnityEngine;

public class CarCollider : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D obj)
    {
        if(obj.collider.CompareTag("wall"))
        {
            Debug.Log("Wall hit");
        }

        if(obj.collider.CompareTag("enemy"))
        {
            Debug.Log("Enemy hit");
        }
    }
    private void OnTriggerEnter2D(Collider2D obj)
    {
        if(obj.CompareTag("item"))
        {
            Debug.Log("Item collected");
            Destroy(obj.gameObject);
        }
    }
}
