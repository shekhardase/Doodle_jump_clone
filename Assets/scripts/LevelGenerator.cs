using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject platformsPrefab;
    public int NumberOfPlatforms;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;
    void Start()
    {
        Vector3 spawnposition = new Vector3();
        for (int i = 0; i < NumberOfPlatforms ; i++)
        {
            spawnposition.y += Random.Range(minY, maxY);
            spawnposition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformsPrefab,spawnposition , Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
