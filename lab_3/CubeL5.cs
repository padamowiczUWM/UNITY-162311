using UnityEngine;
public class CubeL5 : MonoBehaviour
{
    // Instantiates prefabs in a circle formation
    public GameObject prefab;
    public int numberOfObjects = 10;
    public float radius = 5f;
    void Start()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            float x = Mathf.Cos(angle) * Random.Range(-4.5f, radius);
            float z = Mathf.Sin(angle) * Random.Range(-4.5f, radius);
            Vector3 pos = transform.position + new Vector3(x, -1f, z);
            Instantiate(prefab, pos, Quaternion.identity);
        }
    }
}