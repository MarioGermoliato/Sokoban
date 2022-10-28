using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Dir { Direita, Esquerda, Cima, Baixo}
public class Player : MonoBehaviour
{
    private Vector3 target;
    private Vector3 direcao;
    //private Dir sentido;
    [SerializeField] private SceneController sceneController;
    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //direcao = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        Debug.Log(target);
        InputHandler();
    }

    private void TentarAndar()
    {
        foreach (Transform caixa in sceneController.caixas)
        {
            {
                if (target == caixa.position)
                {

                   if (caixa.GetComponent<Box>().TentarEmpurrar(direcao) == false)
                    {
                        target = transform.position;
                    }
                   else if (caixa.GetComponent<Box>().TentarEmpurrar(direcao) == true)
                    {
                        caixa.transform.position = caixa.transform.position + direcao;                        
                    }
                        
                    
                }
            }

            foreach (Transform parede in sceneController.paredes)
            {
                if (target == parede.position)
                {
                    target = transform.position;
                    return;
                }
            }
        }
        //transform.position = Vector3.MoveTowards(transform.position, target, 5 * Time.deltaTime);
        transform.position = target;

    }

    private void InputHandler()
    {
        TentarAndar();

        if (transform.position != target)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            target += Vector3.up;
            direcao = Vector3.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            target += Vector3.down;
            direcao = Vector3.down;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            target += Vector3.right;
            direcao = Vector3.right;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            target += Vector3.left;
            direcao = Vector3.left;
        }

        if (transform.position == target)
        {
            target = transform.position;
        }
    }
}
