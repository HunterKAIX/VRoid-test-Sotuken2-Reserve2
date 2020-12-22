using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRoidScaleChanger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            gameObject.transform.localScale = new Vector3(
            gameObject.transform.localScale.x + 0.1f,
            gameObject.transform.localScale.y,
            gameObject.transform.localScale.z
            );
        } else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            gameObject.transform.localScale = new Vector3(
            gameObject.transform.localScale.x - 0.1f,
            gameObject.transform.localScale.y,
            gameObject.transform.localScale.z
            );
        } else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            gameObject.transform.localScale = new Vector3(
            gameObject.transform.localScale.x,
            gameObject.transform.localScale.y + 0.1f,
            gameObject.transform.localScale.z
            );
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            gameObject.transform.localScale = new Vector3(
            gameObject.transform.localScale.x,
            gameObject.transform.localScale.y - 0.1f,
            gameObject.transform.localScale.z
            );
        }

    }
}
