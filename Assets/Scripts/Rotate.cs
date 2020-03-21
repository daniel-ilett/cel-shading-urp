using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Vector3 startPos;

    private void Awake()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        transform.position = startPos + new Vector3(0.0f, Mathf.Sin(Time.time) * 0.025f, 0.0f);

        transform.rotation = Quaternion.Euler(0.0f, (Time.time * 60.0f) % 360.0f, 0.0f);
    }
}
