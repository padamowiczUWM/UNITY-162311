using System;
using Random = UnityEngine.Random;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class L1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    int objectCounter = 0;
    public int objectCount = 10;
    // obiekt do generowania
    public GameObject block;
    public Material[] materialObjects;

    void Start()
    {
        for (int i = 0; i < objectCount; i++)
        {
            this.positions.Add(new Vector3(transform.position.x + Random.Range(-5f, 5f), 5, transform.position.z + Random.Range(-5f, 5f)));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywo³ano coroutine");
        foreach (Vector3 pos in positions)
        {
            GameObject newCube = Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            int materialIndex = Random.Range(0, materialObjects.Length);
            Material randomMaterial = materialObjects[materialIndex];
            newCube.GetComponent<Renderer>().material = randomMaterial;
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}