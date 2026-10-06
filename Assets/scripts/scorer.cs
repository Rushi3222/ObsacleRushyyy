using UnityEngine;

public class scorer : MonoBehaviour
{

    int score = 0;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   void OnCollisionEnter(Collision Other)
    {
        Debug.Log("you hit this for this much time :" + score);

        score++;
    
    }
}
