using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DocImportante : MonoBehaviour
{
    
    public GameObject[] Docs; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool TodosDesactivados = true;
        foreach(GameObject g in Docs)
        {
            if (g.activeSelf)
            {
                TodosDesactivados = false;
            }
        }

        if (TodosDesactivados == true)
        {
           SceneManager.LoadScene("Gameover");
        }
        
    }
}
