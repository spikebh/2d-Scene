using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    private Rigidbody2D ringBody;
    // Start is called before the first frame update
    void Start()
    {
        ringBody = GetComponent<Rigidbody2D>();
        ringBody.mass = Random.Range(0.1f, 10.0f);
        ringBody.position = new Vector2(Random.Range(-7.49f, -0.26f), Random.Range(7.69f, 9.66f));
        ringBody.gravityScale = Random.Range(0.1f, 3.0f);
        ringBody.drag = Random.Range(0.1f, 2.0f);
        Debug.Log("mass " + ringBody.mass);
        Debug.Log("position " + ringBody.position);
        Debug.Log("gravity drag " + ringBody.gravityScale + " " + ringBody.drag);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
