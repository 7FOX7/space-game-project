using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float lifeTime;
    public Vector3 scaleChange; 
    void Awake()
    {
        lifeTime = 3.0f;
        scaleChange = new Vector3(1.0f, 1.0f, 0); 
    }
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Destroy(gameObject, lifeTime); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange * Time.deltaTime; 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"{gameObject.name} collides with {collision.gameObject.name}"); 
    }
}
