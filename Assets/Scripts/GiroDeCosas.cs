using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroDeCosas : MonoBehaviour
{
    public float f1;
    public float f2;
    public float f3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(f1, f2, f3) * Time.deltaTime);
    }
}
