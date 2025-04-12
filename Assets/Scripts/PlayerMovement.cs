using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 10f;
       // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - 1, -10f, 10f), -4, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + 1, -10f, 10f), -4, 0);
        }
    }
}
