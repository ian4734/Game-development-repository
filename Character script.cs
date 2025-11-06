using UnityEngine;
using System.Collections;

public class Characterscripts : MonoBehaviour {

// Use this for initialization
void Start ()
{
    
}

// Update is called once per frame
void Update ()
{
print (Input.GetAxis("Horizontal"));

transform.Translate(Input.GetAxis("Horizontal")* Time.deltaTime,0f,0f);

}
private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "pickup")
        {
            // Here you can do all sorts of cool stuff with the collected coin.
            // Like rotate it, activate particles, play audio, or just destroy it.

            // Destroys collected coin.
            Destroy(collider.gameObject);
        }
    }
} 