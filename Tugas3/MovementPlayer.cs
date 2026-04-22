using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 arah = new Vector3(h, v, 0);

        // Gerak
        transform.Translate(arah * speed * Time.deltaTime, Space.World);

        // Rotasi mengikuti arah gerak
        if (arah != Vector3.zero)
        {
            float angle = Mathf.Atan2(arah.y, arah.x) * Mathf.Rad2Deg;

            // -90 karena sprite kamu hadap atas (top-down)
            transform.rotation = Quaternion.Euler(0, 0, angle - 90f);
        }
    }
}