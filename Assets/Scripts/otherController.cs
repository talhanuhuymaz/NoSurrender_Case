using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class otherController : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private VariableJoystick joyStick;
    [SerializeField] private Animator anim;
    [SerializeField] private float speed;


    private void FixedUpdate()
    {
        rb.velocity = new Vector3(joyStick.Horizontal * speed, rb.velocity.y, joyStick.Vertical * speed);

        //here we controle the joystick movements
        if (joyStick.Horizontal !=0  || joyStick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity);
            anim.SetBool("Run", true);
        }
        //if horizontal or vertival is = 0, the run anim will be false
        else
            anim.SetBool("Run",false);
    }
}
