using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool TentarEmpurrar(Vector3 direcao)
    {
        foreach (Transform parede in sceneController.paredes)
        {
            foreach (Transform caixa in sceneController.caixas)
            {
                if (transform.position + direcao == parede.position || transform.position + direcao == caixa.position)
                {
                    Debug.Log("Tem parede");
                    return false;
                }
            }
            
        }
        return true;
        

    }
}
