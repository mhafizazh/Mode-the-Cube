using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float speed = 10.0f; 
    private float randomChannelOne, randomChannelTwo, randomChannelThree;
    
    void Start()
    {
        //transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 3f;
        ChangeColor();
        
    }
    
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, 0.0f, 0.0f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor();
        }
        
    }
    private void ChangeColor()
    {
        randomChannelOne = Random.Range(0f, 3f);
        randomChannelTwo = Random.Range(0f, 3f);
        randomChannelThree = Random.Range(0f, 3f);

        Material material = Renderer.material;
        material.color = new Color(randomChannelOne, randomChannelTwo, randomChannelThree, 200f);
    
    }
    
}
