using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidbody;
    public float acceleration;
    public Camera camera;
    public float force;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {

    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.rotation.z);
        if (Mathf.Abs(transform.rotation.z) >= 0.5f && Mathf.Abs(GetComponent<Rigidbody2D>().angularVelocity) < 0.3f )
        {

            float torque = -45f * force;
            rigidbody.AddTorque(torque);
        }
        if (Mathf.Abs(transform.rotation.z) <= -0.5f && Mathf.Abs(GetComponent<Rigidbody2D>().angularVelocity) > -0.3f )
        {

            float torque = 45f * force;
            rigidbody.AddTorque(torque);
        }
        camera.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
        //rigidbody.AddForce(Vector2.right * acceleration);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.contacts[0].normal.y < -0.5f && collision.gameObject.tag == "Ground") // Проверяем, что объект перевернулся
        {
            float rotationZ = transform.eulerAngles.z;
            if (rotationZ > 180) rotationZ -= 360;
            float torque = -rotationZ * 10f; // Добавляем крутящий момент, чтобы объект повернулся в правильное положение
            rigidbody.AddTorque(torque);
        }
    }
}
