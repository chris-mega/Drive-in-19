using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float scale = 50;
    [SerializeField] private Vector3 entranceCoord = new Vector3(4f, 0.5f, -6f);
    [SerializeField] private Vector3 stopCoord = new Vector3(-2.5f, 0.5f, -6f);
    private int stage = 0;
    // Start is called before the first frame update
    void Start() {
        transform.position = entranceCoord;
        transform.localScale = new Vector3(scale, scale, scale);
        transform.Rotate(0, 180, 0, Space.Self);
    }

    // Update is called once per frame
    void Update() {
        if (stage == 0) {
            if(Vector3.Distance(transform.position, stopCoord) >= 0.01f) {
                transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            } else stage = 1;
        }
    }

    public void MoveToPoint(Vector3 point){
        if (stage == 1)
            transform.position = new Vector3(point.x, transform.position.y, point.z);
    }
}
