using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{
    public float velocidadeMovimento = 5.0f;
    public float velocidadeRota��o = 200.0f;
    private Animator anim;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
        
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0, x * Time.deltaTime * velocidadeRota��o, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadeMovimento);
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelX", y);



    }


    
}
