using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Location : MonoBehaviour
{
    [SerializeField] private SceneController sceneController;
    [SerializeField] private int numeroDestino;    
    [SerializeField] private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Box")
        {
            sceneController.destinos[numeroDestino] = true;
            spriteRenderer.color = Color.green;
            sceneController.TestarResolucao();
        }       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        sceneController.destinos[numeroDestino] = false;
        spriteRenderer.color = Color.red;
    }
}
