using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public int cameraSpeed;
    // Update is called once per frame
    void Update()
    {
        //scroll the camera
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * cameraSpeed);
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * cameraSpeed);
        }
    }
}
