using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float PlayerSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horiz = Input.GetAxisRaw("Horizontal");
        float vert = Input.GetAxisRaw("Vertical");
        transform.Translate(horiz * PlayerSpeed * Time.deltaTime, 0, vert * PlayerSpeed * Time.deltaTime);
    }
}
