using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//アニメーション途中で関数を実行
public class DogManager : MonoBehaviour
{
    Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        //コードからアニメーション切り替え
        if (Input.GetKeyDown(KeyCode.Space)) {
            animator.SetTrigger("Attack");
        }

        if (Input.GetKeyDown(KeyCode.M)) {
            animator.SetFloat("MoveSpeed", 1.1f);
        }

        if (Input.GetKeyDown(KeyCode.N)) {
            animator.SetFloat("MoveSpeed", 0f);
        }
    }

    public void HitLog() {
        Debug.Log("Hit!!");
    }
}

