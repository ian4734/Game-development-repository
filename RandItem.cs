using UnityEngine;

public class RandItem : MonoBehaviour
{
    
    [SerializeField] private string[] naam = new string[10];
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))PrintRandomItem();
        if(Input.GetKeyDown(KeyCode.Escape))PrintAllItems();
    }
    private void PrintRandomItem() {
        //printen van 1 random item.
       Debug.Log(Random.Range(0, 9));
    }
    private void PrintAllItems() {
        //Printen van alle items
        foreach (string item in naam) {Debug.Log(item);}
        {
            
        }
    }

}
  