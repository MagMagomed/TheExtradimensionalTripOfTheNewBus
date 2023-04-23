using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidbody;
    public float acceleration;
    public Camera camera;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
        rigidbody.AddForce(Vector2.right * acceleration);
    }
}
