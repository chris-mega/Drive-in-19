using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private static int lives = 3;
    private static SpawnManager spawnManager;
    // Start is called before the first frame update
    void Start() {
        spawnManager = GameObject.Find("CarSpawner").GetComponent<SpawnManager>();
        if (spawnManager == null)
            Debug.LogError("CarSpawner is null");
    }

    // Update is called once per frame
    void Update() {
        
    }

    public static void Damage() {
        lives--;
        if(lives <= 0) {
            spawnManager.OnPlayerDeath();
        }
        print(lives);
    }
}
