using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speedball;
    public GameObject teamleft;
    public GameObject teamright;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(Pause());
    }
    void Update()
    {
        if(Mathf.Abs(this.transform.position.x) >= 14f){
            Count_Score.canAddScore = true;
            this.transform.position = new Vector3(0f,0f,0f);
            StartCoroutine(Pause());
        }
    }
    IEnumerator Pause(){
        int dX = Random.Range(-1,2);
        int dY = Random.Range(-1,2);
        if(dX == 0){
            dX = 1;
        }
        rb.velocity = new Vector2 (0f, 0f);
        yield return new WaitForSeconds(2);
        rb.velocity = new Vector2 (speedball * dX, speedball * dY);
    }
    void  OnCollisionEnter2D (Collision2D hit ){
        if(hit.gameObject.name == "Basic Racket_left"){
            if(teamleft.GetComponent<Rigidbody2D>().velocity.y > 0.5f){
                rb.velocity = new Vector2 (speedball , speedball);
            } else if (teamleft.GetComponent<Rigidbody2D>().velocity.y < -0.5f){
                rb.velocity = new Vector2 (speedball , -speedball);
            } else{
                rb.velocity = new Vector2 (speedball , 0);
            }
        }
        if(hit.gameObject.name == "Basic Racket_right"){
            if(teamright.GetComponent<Rigidbody2D>().velocity.y > 0.5f){
                rb.velocity = new Vector2 (-speedball , speedball);
            } else if (teamright.GetComponent<Rigidbody2D>().velocity.y < -0.5f){
                rb.velocity = new Vector2 (-speedball , -speedball);
            } else{
                rb.velocity = new Vector2 (-speedball , 0);
            }
        }
    }
}
