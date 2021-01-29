using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    public Camera camera;
    private PlayerInputs controls;
    public float movementSpeed;
    private Vector2 movement;
    private double deadzone = 0.2;
    private Rigidbody rigidbody;

    // Update is called once per frame

    private void Start()
    {
        controls = new PlayerInputs();
        controls.Player.Enable();
        rigidbody = GetComponent<Rigidbody>();

    }

    void Update()
    {
        AimTorch();
        Move();
        ZeroVelocity();
    }

    private void Move()
    {
        var movement = controls.Player.Move.ReadValue<Vector2>();
        if (movement.magnitude >= deadzone || movement.magnitude <= -deadzone)
        {
            transform.Translate(new Vector3(movement.x, 0, movement.y) * Time.deltaTime * movementSpeed);
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
}
