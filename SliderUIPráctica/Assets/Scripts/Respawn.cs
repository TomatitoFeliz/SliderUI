using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    float contador;
    int random;

    private void Start()
    {        

        random = Random.Range(5, 20);
        Debug.Log(random);
        contador = random;
    }
    private void Update()
    {
        contador -= Time.deltaTime;
        Debug.Log(contador);
        if (contador <= 0f)
        {
            Debug.Log("Spawn");
            Instantiate(prefab, new Vector3(Random.Range(-7f, 7f), 1f, Random.Range(-8f, 8f)), Quaternion.identity);
            random = Random.Range(5, 20);
            contador = random;
            //Reinicio();
        }
    }
    /*void Reinicio()
    {
        int random = Random.Range(5, 11);
    }*/
}
