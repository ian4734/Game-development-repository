using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
      
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left, 80.0f * Time.deltaTime);
        transform.Rotate(Vector3.up, 80.0f * Time.deltaTime);
    }
}