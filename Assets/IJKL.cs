using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IJKL : MonoBehaviour
{
    [SerializeField] float speed;
    int x;
    int y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y = 0; x = 0; 

        if (Input.GetKey(KeyCode.I))
            {
               y = y + 1;
            }

        if (Input.GetKey(KeyCode.K))
            {
               y = y - 1;
            }

        if (Input.GetKey(KeyCode.L))
            {
               x = x + 1;
            }

        if (Input.GetKey(KeyCode.J))
            {
               x = x - 1;
            }
        Vector3 pos = transform.position;
        transform.position = new Vector3(pos.x + x * speed * Time.deltaTime, pos.y + y * speed * Time.deltaTime, pos.z);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "danger")
        {
           SceneManager.LoadScene(0);
        }
    }
}
