using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InGameValues;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private BoxCollider collider;
    public Camera camera;
    private PlayerInputs controls;
    public float movementSpeed;
    private Vector2 movement;
    private double deadzone = 0.2;
    private Rigidbody rigidbody;


    private bool menuPressed;
    private bool menuWasPressed;
    private bool actionPressed;
    private bool actionWasPressed;

    // Update is called once per frame

    private void Start()
    {
        ButtonInitialStatus();
        controls = new PlayerInputs();
        controls.Player.Enable();
        rigidbody = GetComponent<Rigidbody>();

    }

    void Update()
    {
        ButtonStatusUpdate();
        Menu();
        if (!paused){
            AimTorch();
            Move();
            Action();
        }
        ZeroVelocity();
    }

    private void Menu()
    {
        if (menuPressed && !menuWasPressed)
        {
            GameEvents.current.PressPause();
        }
    }

    private void LateUpdate()
    {
        ButtonStatusLateUpdate();
    }

    private void ButtonInitialStatus()
    {
        menuPressed = false;
        actionPressed = false;
    }

    private void ButtonStatusUpdate()
    {
        if (controls.Player.Pause.ReadValue<float>() == 1)
        {
            menuPressed = true;
        }
        else
        {
            menuPressed = false;
        }
        if (controls.Player.Action.ReadValue<float>() == 1)
        {
            actionPressed = true;
        }
        else
        {
            actionPressed = false;
        }
    }

    private void ButtonStatusLateUpdate()
    {
        menuWasPressed = menuPressed;
        actionWasPressed = actionPressed;
    }

    private void Move()
    {
        var movement = controls.Player.Move.ReadValue<Vector2>();
        if (movement.magnitude >= deadzone || movement.magnitude <= -deadzone)
        {
            transform.Translate(new Vector3(movement.x, 0, movement.y) * Time.deltaTime * movementSpeed);
        }
    }

    private void Action()
    {
        if (actionPressed && !actionWasPressed)
        {
            collider.enabled = true;
            StartCoroutine(DeactivateCollider(collider));
        }
    }

    private void ZeroVelocity()
    {
        rigidbody.velocity = Vector3.zero;
    }

    private void AimTorch()
    {
        var aimVec = controls.Player.MousePosition.ReadValue<Vector2>();

        var aimVecWorld = camera.ScreenToWorldPoint(new Vector3(aimVec.x, aimVec.y, 10.0f));
        aimVecWorld = (Vector3)aimVecWorld - player.transform.position;
        var aimAngle = Mathf.Atan2(aimVecWorld.x, aimVecWorld.z) * 180 / Mathf.PI;
        player.transform.eulerAngles = new Vector3(player.transform.rotation.eulerAngles.x,aimAngle, player.transform.rotation.eulerAngles.z);
    }

    IEnumerator DeactivateCollider(BoxCollider collider)
    {
        yield return new WaitForFixedUpdate();
        collider.enabled = false;
    }
}
