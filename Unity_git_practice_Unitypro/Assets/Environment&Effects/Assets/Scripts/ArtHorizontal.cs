using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtHorizontal : MonoBehaviour
{
    private Quaternion nowRotation;
    private float rotateSpeed = 0.1f;



    private void Update()
    {
        nowRotation = transform.rotation;
        if ( Input.GetKey("a"))
        {
            Quaternion moveRotation = Quaternion.Euler(new Vector3(0,-rotateSpeed,0));
            transform.rotation = nowRotation * moveRotation;
            nowRotation = transform.rotation;
        }
        if (Input.GetKey("d"))
        {
            Quaternion moveRotation = Quaternion.Euler(new Vector3(0,rotateSpeed, 0));
            transform.rotation = nowRotation * moveRotation;
            nowRotation = transform.rotation;
        }

    }// ���콺 ���� ������, �Ʒ������� ���ο�����
}
