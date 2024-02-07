using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    private Vector3 moveDir;
    private float moveSpeed;

    private float yaw;
    private float pitch;
    [SerializeField]
    private Camera myCam;

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        moveSpeed = 5f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //get WASD input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //move player in direction based on WASD input
        moveDir = Vector3.forward * verticalInput + Vector3.right * horizontalInput;
        transform.Translate(moveDir * moveSpeed * Time.deltaTime);
        
        //jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        //get rotation from cursor
        yaw += 4f * Input.GetAxis("Mouse X");
        pitch = 3f * Input.GetAxis("Mouse Y");

        //rotate player side to side
        transform.eulerAngles = new Vector3(0, yaw, 0);
        //rotate camera up and down
        myCam.transform.RotateAround(myCam.transform.position, myCam.transform.right, -pitch);

        
        if (Input.GetMouseButtonDown(0))
        {
            GameObject proj = Instantiate(projectile, transform.position + transform.forward, transform.rotation);
            proj.GetComponent<Rigidbody>().AddForce(transform.forward * 9f, ForceMode.Impulse);
            Destroy(proj, 7f);
        }
    }
}

