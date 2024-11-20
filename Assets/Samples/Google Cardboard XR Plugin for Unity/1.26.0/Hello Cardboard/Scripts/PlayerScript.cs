using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController cc;
    public Transform vrCamera;
    public float speed = 4.0f;
    public bool moveForward;

    public int score = 0;
    public Text scoreText;

    void Start()
    {
        cc = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: "+score.ToString();

        if(vrCamera.eulerAngles.x>=30.0f && vrCamera.eulerAngles.x < 90.0f)
        {
            moveForward = true;
        }
        else
        {
            moveForward = false;
        }
        if (moveForward)
        {
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward);
        }
        
    }
}
