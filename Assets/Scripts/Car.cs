using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float init_x = 4f;
    [SerializeField] private float init_y = 0.5f;
    [SerializeField] private float init_z = -6f;
    [SerializeField] private float scale = 50;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(init_x, init_y, init_z);
        transform.localScale = new Vector3(scale, scale, scale);
        transform.Rotate(0, 180, 0, Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);

    }
}
