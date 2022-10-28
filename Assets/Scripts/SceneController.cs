using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Transform[] paredes;
    public Transform[] caixas;
    public bool[] destinos;
    private bool levelResolvido;
    [SerializeField] private string proximaFase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void TestarResolucao()
    {
        for (int i = 0; i < destinos.Length; i++)
        {
            if(destinos[i] != true)
            {
                return;
            }
        }
        SceneManager.LoadScene(proximaFase);
    }
    
}
