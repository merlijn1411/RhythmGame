using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Linq;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnObjects : MonoBehaviour
{
    public List<GameObject> ArrowPrefabs = new List<GameObject>();
    public float delay = 2f;
    public float speed = 3f;

    private float nextTimeToSpawn;

    private void Start()
    {
        nextTimeToSpawn = Time.time;
    }

    private void Update()
    {
        if (Time.time > nextTimeToSpawn)
        {
            nextTimeToSpawn = Time.time + delay;


            int randomIndex = Random.Range(0, ArrowPrefabs.Count);
            GameObject go = Instantiate(ArrowPrefabs[randomIndex], transform.position, Quaternion.identity);
            go.AddComponent<Move>().speed = speed;
        }
    }
}

public class Move : MonoBehaviour
{
    public float speed;

    private Score score;

    void Awake()
    {
        score = FindObjectOfType<Score>();
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);    
    }

    void OnBecameInvisible()
    {
        score.addscore();
        Destroy(gameObject);    
    }
}