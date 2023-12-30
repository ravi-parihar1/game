using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
    private bool arrowKeyPressed = false;
    private string arrowKeyCode;
    public GameObject Pivot;

    public float gravity;

    [SerializeField]
    private GameObject Level;

    [SerializeField]
    private float RotationSpeed = 5f; // Adjust the rotation speed as needed

    private void Update()
    {
        // Check arrow key inputs
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            SetArrowKeyValues("Left");
            Debug.Log("Left Arrow Key Pressed");
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            SetArrowKeyValues("Right");
            Debug.Log("Right Arrow Key Pressed");
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SetArrowKeyValues("Up");
            Debug.Log("Up Arrow Key Pressed");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SetArrowKeyValues("Down");
            Debug.Log("Down Arrow Key Pressed");
        }

        // Check if Enter/Return key is pressed
        if (arrowKeyPressed && Input.GetKeyDown(KeyCode.Return))
        {
            HandleEnterKey();
        }
    }

    private void SetArrowKeyValues(string keyCode)
    {
        arrowKeyPressed = true;
        arrowKeyCode = keyCode;
    }

    private void HandleEnterKey()
    {
        switch (arrowKeyCode)
        {
            case "Left":
                //RotateLevel(Vector3.up * 90f);
                break;
            case "Right":
                //RotateLevel(Vector3.up * -90f);
                break;
            case "Up":
                //RotateLevel(Vector3.right * 180f);
                break;
            case "Down":
                // Handle Down key if needed
                break;
            default:
                Debug.Log("Invalid arrow key");
                break;
        }

        arrowKeyPressed = false;
    }

    private void RotateLevel(Vector3 rotation)
    {
        //Quaternion targetRotation = Quaternion.Euler(Level.transform.eulerAngles + rotation);
        //Level.transform.rotation = Quaternion.Slerp(Level.transform.rotation, targetRotation, RotationSpeed * Time.deltaTime);
    }
    
}
