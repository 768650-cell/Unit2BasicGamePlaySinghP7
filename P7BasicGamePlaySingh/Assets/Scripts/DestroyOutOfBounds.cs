using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
    {

    public float LeftLimit = 33;
    public float bottomLimit = 10;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes pass the players view in the game, remove that object
        if (transform.position.x < -LeftLimit)
        {
            
            Destroy(gameObject);
        }
        else if (transform.position.y < bottomLimit)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
        
    }
}
