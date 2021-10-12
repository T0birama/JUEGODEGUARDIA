using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject DocPrefab;
    public float Area ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnearDocs();
    }

    void spawnearDocs()
    {
        Vector3 randomPos = Random.insideUnitSphere * Area;

        Instantiate(DocPrefab, randomPos, Quaternion.identity);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(this.transform.position, Area);
    }
}
