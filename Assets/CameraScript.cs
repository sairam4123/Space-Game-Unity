﻿using UnityEngine;
using UnityEngine.Timeline;

public class CameraScript : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt))
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                var eulerAngles = transform.rotation.eulerAngles;
                eulerAngles += Vector3.left * Time.deltaTime;
                var quaternion = Quaternion.Euler(eulerAngles);
                transform.rotation = quaternion;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                var eulerAngles = transform.rotation.eulerAngles;
                eulerAngles += Vector3.right * Time.deltaTime;
                var quaternion = Quaternion.Euler(eulerAngles);
                transform.rotation = quaternion;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                var eulerAngles = transform.rotation.eulerAngles;
                eulerAngles += Vector3.up * Time.deltaTime;
                var quaternion = Quaternion.Euler(eulerAngles);
                transform.rotation = quaternion;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                var eulerAngles = transform.rotation.eulerAngles;
                eulerAngles += Vector3.down * Time.deltaTime;
                var quaternion = Quaternion.Euler(eulerAngles);
                transform.rotation = quaternion;
            }
            else if (Input.GetKey(KeyCode.PageUp))
            {
                transform.localPosition += Vector3.forward * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.PageDown))
            {
                transform.localPosition += Vector3.back * Time.deltaTime;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector3.up * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector3.left * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector3.right * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.PageUp))
            {
                transform.Translate(Vector3.forward * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.PageDown))
            {
                transform.Translate(Vector3.back * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.W))
            {
                transform.Rotate(Vector3.left, 0.5f);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Rotate(Vector3.right, 0.5f);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up, 0.5f);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.down, 0.5f);
            }

            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(Vector3.forward, 0.5f);
            }
            else if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(Vector3.back, 0.5f);
            }
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0) *
                             (Time.deltaTime * 200f));
        }
    }
}