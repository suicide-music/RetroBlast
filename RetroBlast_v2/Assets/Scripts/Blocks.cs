using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    
    public AudioClip blockDestroyedSound;
 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            AudioSource.PlayClipAtPoint(blockDestroyedSound, transform.position);
            Destroy(gameObject);
        }
    }
}
