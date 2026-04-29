using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 🔍 TAMPILKAN INPUT
        Debug.Log("Horizontal: " + h + " | Vertical: " + v);

        Vector3 arah = new Vector3(h, v, 0);

        transform.Translate(arah * speed * Time.deltaTime, Space.World);

        if (arah != Vector3.zero)
        {
            float angle = Mathf.Atan2(arah.y, arah.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle - 90f);
        }
    }
}