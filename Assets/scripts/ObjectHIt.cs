using UnityEngine;

public class ObjectHIt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  void OnCollisionEnter(Collision Other)
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
    }

}
