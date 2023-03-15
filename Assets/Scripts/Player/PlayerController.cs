using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
    public float walkingSpeed = 7.5f;
    public static float runningSpeed ;
    public float sprintingSpeed;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public Camera playerCamera;
    public float lookSpeed = 2.0f;
    public float lookXLimit = 45.0f;
    public  float stamina = 30;
    public float maxStamina;
    public Slider staminaBar;
    public Slider mouseSenBar;
    public float dvalue;
    public float ivalue;
  
   

    CharacterController characterController;
    public Vector3 moveDirection = Vector3.zero;
    float rotationX = 0;

    [HideInInspector]
    public static bool canMove=true ;
    public static bool AllowedToJump;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        stamina=maxStamina;
        staminaBar.maxValue = maxStamina;
        mouseSenBar.value = lookSpeed / 10;
        runningSpeed = sprintingSpeed;
        // Lock cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    void Update()
    {
        // We are grounded, so recalculate move direction based on axes
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);
        // Press Left Shift to run
        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? (isRunning ? runningSpeed : walkingSpeed) * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        if (Input.GetButton("Jump") && canMove && characterController.isGrounded && AllowedToJump)
        {
            moveDirection.y = jumpSpeed;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }
       
        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);

        // Player and Camera rotation
       
        if (canMove)
        {
            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;
            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);
            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);
        }
        //Stamina
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w")|| Input.GetKey(KeyCode.LeftShift) && Input.GetKey("a")|| Input.GetKey(KeyCode.LeftShift) && Input.GetKey("s")|| Input.GetKey(KeyCode.LeftShift) && Input.GetKey("d"))
            DecreaseEnergy();
        else if (stamina != maxStamina)
            Invoke("IncreaseEnergy", 1f);
        staminaBar.value = stamina;
        if (stamina == 0)
        {
            runningSpeed = walkingSpeed;
        }
        else
            runningSpeed = 0;
        if (stamina < 0)
        {
            runningSpeed = walkingSpeed;
            stamina=0;
            
        }
        if (stamina > 0)
        {
            runningSpeed = sprintingSpeed;
            
        }



    }
    private void DecreaseEnergy()
    {
        if (stamina != 0)
        {
            stamina -= dvalue * Time.deltaTime;
        }
    }
    private void IncreaseEnergy()
    {

        stamina += ivalue * Time.deltaTime;
        if (stamina > maxStamina)
        {
            stamina = maxStamina;
        }
        
                
    }
    public void adjustSensSpeed(float newSpeed)
    {
        lookSpeed = newSpeed * 10;
    }
}