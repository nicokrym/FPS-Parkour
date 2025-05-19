using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartOnFall : MonoBehaviour
{
    public float alturaCaida = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < alturaCaida)
        {
            Debug.Log("Me caí");
            SceneManager.LoadScene("Parkour");
        }
    }
}
