using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Missions : MonoBehaviour
{
   
    public TextMeshProUGUI textoMision;
    public int numDeObjetivos;
    public GameObject botaoMissao;
    public static Missions instance;

 
    void Start()
    {

        numDeObjetivos = GameObject.FindGameObjectsWithTag("objetivo").Length;
        textoMision.text = "Pegue todas as esferas ! Descubra o mistério da ilha " + numDeObjetivos;


    }

    // Update is called once per frame
    void Update()
    {
    
    }

     void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "dialogo")
        {
            Debug.Log("Estou preso ! Preciso de minhas esferas ! São 5, pode me ajudar ?");
        }

        if(col.gameObject.tag == "objetivo")
        {
            Debug.Log("Pegou a moeda ! "+numDeObjetivos);
            Destroy(col.transform.parent.gameObject);
            numDeObjetivos--;
            textoMision.text = "Pegue todas as esferas !" + numDeObjetivos;
            if(numDeObjetivos <= 0)
            {
                textoMision.text = "Missão completada !";
                botaoMissao.SetActive(true);
            }
        }
    }
}
