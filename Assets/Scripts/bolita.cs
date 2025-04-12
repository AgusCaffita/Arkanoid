using Unity.VisualScripting;
using UnityEngine;

public class bolita : MonoBehaviour
{
    Collider cd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cd = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entered");
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Entered");
        }
    }
}
