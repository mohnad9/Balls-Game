
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;

    bool ismove = false;
    int btn_num = 0;

    void Update()
    {
        // for keys
        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector3(0, 0, speed));
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(new Vector3(0, 0, -speed));
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(speed, 0, 0));
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(-speed, 0,0));
        }

        // for mobile
        if (ismove && btn_num == 0)
        {
            rb.AddForce(new Vector3(0, 0, speed));
        }
        if (ismove && btn_num == 1)
        {
            rb.AddForce(new Vector3(0, 0, -speed));
        }
        if (ismove && btn_num == 2)
        {
            rb.AddForce(new Vector3(speed, 0, 0));
        }
        if (ismove && btn_num == 3)
        {
            rb.AddForce(new Vector3(-speed, 0, 0));
        }


    }
    public void P_down(int i)
    {
        ismove = true;
        btn_num = i;
    }
    public void P_up(int i)
    {
        ismove = false;
        btn_num = i;
    }

}
