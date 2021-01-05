using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private float waitTimeSpawnCar = 5;
    [SerializeField] private bool playerAlive = true;
    [SerializeField] private bool queueFull = false;
    [SerializeField] private int maxQueue = 5;
    private static GameObject[] carTypes;
    // Start is called before the first frame update
    void Start()
    {
        carTypes = Resources.LoadAll<GameObject>("Prefabs/Cars");
        if(carTypes.Length != 0)
            StartCoroutine(SpawnCarRoutine());
        else print("No cars in directory");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnCarRoutine()
    {
        while (playerAlive && !queueFull)
        {
            int carIndex = Random.Range(0, carTypes.Length);
            GameObject newCar = Instantiate(carTypes[carIndex], new Vector3(-1, 0, -6), carTypes[carIndex].transform.rotation);
            yield return new WaitForSeconds(waitTimeSpawnCar);
        }
    }
}
