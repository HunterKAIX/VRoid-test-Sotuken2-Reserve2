﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gekisai2StartandStop : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Animator anim = GetComponent<Animator>();

        if (SceneManager.GetActiveScene().name == "Gekisai2")
        {
            anim.SetBool("MirrorSwitch", true);
        }
        else
        {
            anim.SetBool("MirrorSwitch", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("Gekisai2Shift", true);
        }

        AnimatorStateInfo state1 = anim.GetCurrentAnimatorStateInfo(0);
        if (!state1.IsName("Wait"))
        {
            anim.SetBool("Gekisai2Shift", false);
        }

        if (Input.GetKey(KeyCode.T))
        {
            anim.SetBool("Interrupt", true);
            SceneManager.LoadScene("SelectKata");
        }

        AnimatorStateInfo state2 = anim.GetCurrentAnimatorStateInfo(0);
        if (state2.IsName("Wait"))
        {
            anim.SetBool("Interrupt", false);
        }

    }
}
