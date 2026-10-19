using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)&& (transform.position.x <8.6) )
        {
            transform.Translate(Vector2.right * 10 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)&& (transform.position.x>-8.6))
        {
            transform.Translate(Vector2.left * 10 * Time.deltaTime);
        }

    }
}
