using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private InputJooj inputJooj;
    [SerializeField] private float velocity;

    [SerializeField] private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inputJooj.GetKeyDown(inputJooj.left_button))
        {
            ChangeTransform(-Vector3.right);
            spriteRenderer.flipX = false;
            
        }
        if(inputJooj.GetKeyDown(inputJooj.rigth_button))
        {
            ChangeTransform(Vector3.right);
            spriteRenderer.flipX = true;
            
        }
        if(inputJooj.GetKeyDown(inputJooj.foward_button))
        {
            ChangeTransform(Vector3.forward);
            
        }
        if(inputJooj.GetKeyDown(inputJooj.back_button))
        {
            ChangeTransform(-Vector3.forward);
            
        }
    }

    void ChangeTransform(Vector3 direction)
    {
            transform.position += direction * Time.deltaTime * velocity;

    }
}
