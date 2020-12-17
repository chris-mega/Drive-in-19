using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float waitTimeSpawnCar = 5;
    [SerializeField] private bool playerAlive = true;
    [SerializeField] private bool queueFull = false;
    [SerializeField]
    private GameObject[] carTypes;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCarRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCarRoutine()
    {
        while (playerAlive && !queueFull)
        {
            GameObject newCar = Instantiate(carTypes[Random.Range(0, carTypes.Length)]);
            yield return new WaitForSeconds(waitTimeSpawnCar);
        }
    }
}
