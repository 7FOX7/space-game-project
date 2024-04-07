/// <summary>
/// Rotates a game object about Z-axiz. Used primarily for fan and other player attachments. 
/// </summary>
using UnityEngine;

public class Rotate : MonoBehaviour 
{
    // [SerializeField]
    // private float rotateSpeed = 180f;

    // My code: 
    [SerializeField]
    private Vector3 rotation = new Vector3(0, 0, 0); 

	void Update() 
	{
        // Original code: 
        // transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);

        // My code:
        transform.Rotate(rotation); 
    }
}
