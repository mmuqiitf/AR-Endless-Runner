using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    protected Joystick joystick;
    protected JoyButton joyButton;
    protected bool jump;

    private void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joyButton = FindObjectOfType<JoyButton>();
    }

    private void Update()
    {
        Vector3 direction = Vector3.forward * joystick.Vertical + Vector3.right * joystick.Horizontal;
        var rigidbody = GetComponent<Rigidbody>();
        //rigidbody.velocity = new Vector3(joystick.Horizontal * 10f, rigidbody.velocity.y, joystick.Vertical * 10f);
        rigidbody.AddForce(direction * 10f * Time.deltaTime, ForceMode.VelocityChange);

    }


}
