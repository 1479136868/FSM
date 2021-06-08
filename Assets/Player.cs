using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float h = 0;

    private float v = 0;

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if (h != 0 || v != 0)
        {
            transform.LookAt(transform.position + new Vector3(h, 0, v));

            transform.Translate(Vector3.forward * Time.deltaTime * 5f);
        }

    }
}
