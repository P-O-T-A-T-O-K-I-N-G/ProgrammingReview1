using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float vInput;
    public float hInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");

        vInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed * vInput);

        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * hInput);
    }
}
