using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontal;
    float vertical;
    [SerializeField] float moveSpeed;
    [SerializeField] float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        float rotY = horizontal * Time.deltaTime * rotationSpeed;
        float translateZ = vertical * Time.deltaTime * moveSpeed;
        transform.Rotate(0, rotY, 0);

        transform.Translate(0, 0, translateZ);
    }
}
