using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make : MonoBehaviour
{
    public GameObject ex;
    public float timediff;
    float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timediff) {
            GameObject newex = Instantiate(ex);
            newex.transform.position = new Vector3(-12.2f, 6.1f, 0);
            timer = 0;
            Destroy(newex, 4.0f);
        }
    }
}
