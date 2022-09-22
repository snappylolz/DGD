using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerlife : MonoBehaviour
{
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("a");
        if (collision.gameObject.CompareTag("meteorite"))
        {
            die(); 
        }
    }
    
    private void die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        Restartlevel();
        Debug.Log("b");
    }
    
    private void Restartlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
