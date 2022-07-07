using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class make_pipe : MonoBehaviour
{
    public GameObject pipe;
    public float timediff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timediff) {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(5, Random.Range(-0.82f, 5.14f), 0);
            timer = 0;
            Destroy(newpipe, 5.0f);
        }
    }
}
