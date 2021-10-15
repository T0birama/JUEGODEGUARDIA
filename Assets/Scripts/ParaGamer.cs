using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParaGamer : MonoBehaviour
{
    public GameObject esteDoc;
    public GameObject otroDoc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            esteDoc.SetActive(false);
            otroDoc.SetActive(true);
        }
    }
}
