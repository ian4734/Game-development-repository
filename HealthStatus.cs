using UnityEngine;

public class HealthStatus : MonoBehaviour
{
     public int score = 100;
    public int health = 75;
    public string playerName = "ian";
    public bool hasKey = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(health > 80)
        {
           Debug.Log("Excellent health!");
        }
        else if(health > 50)
        {
           Debug.Log("Good health!");
        }
        else if(health > 20)
        {
           Debug.Log("Warning: low health!");
        }
        else if(health > 0)
        {
           Debug.Log("Critical: Very low health!");
        }
        else if(health == 0)
        {
            Debug.Log("game over!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
