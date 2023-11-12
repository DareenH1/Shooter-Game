using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-2, -3, 0) * Time.deltaTime * 1);
        if (transform.position.y < -7f)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.x < -8.5f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D whatIHit)
    {
        if(whatIHit.tag == "Player") 
    {
        GameObject.Find("Gamemanager"). GetComponent<GameManager>().EarnScore(1);
        Destroy(this.gameObject);
  
    }
}
}

