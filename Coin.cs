using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed = 100f;
    private void OnTriggerEnter(Collider orther)
    {
        orther.GetComponent<Player>().CollectCoin();
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
