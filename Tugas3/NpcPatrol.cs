using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed = 2f;
    public float batasKiri = -6f;
    public float batasKanan = 6f;

    public Transform player;

    private bool keKanan = true;

    void Update()
    {
        if (keKanan)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);

            if (transform.position.x >= batasKanan)
            {
                transform.position = new Vector3(batasKanan, transform.position.y, transform.position.z);
                keKanan = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);

            if (transform.position.x <= batasKiri)
            {
                transform.position = new Vector3(batasKiri, transform.position.y, transform.position.z);
                keKanan = true;
            }
        }
        HadapKePlayer();
    }

    void HadapKePlayer()
    {
        if (player == null) return;

        Vector3 direction = player.position - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, angle - 90f);
    }
}