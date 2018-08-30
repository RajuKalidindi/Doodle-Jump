using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    public GameObject platformPrefab;
    public GameObject specialPrefab;

    public int numberOfPlatforms = 10;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;
	// Use this for initialization
	void Start () {
        Vector3 spawnPosition = new Vector3();
        spawnPosition.y += .4f;
        spawnPosition.x = Random.Range(-levelWidth, levelWidth);
        Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        for (int i = 1; i < numberOfPlatforms; i++)
        {
            if (i % 100 == 0)
            {
                spawnPosition.y += Random.Range(minY, maxY);
                spawnPosition.x = Random.Range(-levelWidth, levelWidth);
                Instantiate(specialPrefab, spawnPosition, Quaternion.identity);
            }
            else
            {
                spawnPosition.y += Random.Range(minY, maxY);
                spawnPosition.x = Random.Range(-levelWidth, levelWidth);
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            }          
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
