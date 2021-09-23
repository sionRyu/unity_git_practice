using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour
{

    [SerializeField]
    private GameObject tank;

    private Quaternion nowRotation;
    public float moveSpeed = 5.0f;
    private float rotateSpeed = 0.1f;


    private void Update() 
    {
        nowRotation = transform.rotation;
        if ( Input.GetKey(KeyCode.UpArrow) && transform.rotation.x < 90 && transform.rotation.x < 270)
        {
            transform.Translate(new Vector3(0.01f,0,0));
        }
        if ( Input.GetKey(KeyCode.DownArrow) && transform.rotation.x < 90 && transform.rotation.x < 270 )
        {
            transform.Translate(new Vector3(-0.01f, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Quaternion moveRotation = Quaternion.Euler(new Vector3(0, -rotateSpeed, 0));
            transform.rotation = nowRotation * moveRotation;
            nowRotation = transform.rotation;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Quaternion moveRotation = Quaternion.Euler(new Vector3(0, rotateSpeed, 0));
            transform.rotation = nowRotation * moveRotation;
            nowRotation = transform.rotation;
        }
    }

    private void Move( Vector3 direction)
    {
        transform.position += direction * moveSpeed*Time.deltaTime;
        //= Vector3.Lerp(transform.position,transform.position + 5 * direction, Time.deltaTime);
        //transform.position +=  speed * direction * Time.deltaTime;
    }

}
