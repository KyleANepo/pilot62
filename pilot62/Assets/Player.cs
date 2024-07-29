using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // two is the middle!
    int position;

    // Start is called before the first frame update
    void Start()
    {
        position = 2;   
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
    }

    void getInput()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (position > 0)
                position -= 1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (position < 4)
                position += 1;
        }

        Debug.Log(position);
        transform.position = new Vector3(GameManager.Instance.grid[position], 3, 0);
    }
}
