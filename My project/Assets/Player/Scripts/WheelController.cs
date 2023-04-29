using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    HingeJoint2D join;
    // Start is called before the first frame update
    void Start()
    {
        join = GetComponent<HingeJoint2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (join != null && collision.gameObject.tag != "Player")
        {
            join.useMotor = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (join != null && collision.gameObject.tag != "Player")
        {
            join.useMotor = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
