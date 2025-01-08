using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject summon;
    [SerializeField] float rate;
    float time;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject go;
        if (time > rate)
        {
            go = Instantiate(summon);
            go.GetComponent<EnemyFollow>().player = player;
            time -= rate;
        }
        time += Time.deltaTime;
    }
}
