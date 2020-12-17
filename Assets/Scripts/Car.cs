using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private float init_y = 8f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(4, 0, -6);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

    }
}
