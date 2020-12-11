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
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal * 5f, rigidbody.velocity.y, joystick.Vertical * 5f);

        if (!jump && joyButton.Pressed)
        {
            jump = true;
            rigidbody.velocity += Vector3.up * 5f;
            Debug.Log("Jump");
        }

        if (jump && !joyButton.Pressed)
        {
            jump = false;
            Debug.Log("Not Jump");
        }
    }


}
