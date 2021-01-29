using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    public Camera camera;
    private PlayerInputs controls;
    // Update is called once per frame

    private void Start()
    {
        controls = new PlayerInputs();
        controls.Player.Enable();
    }

    void Update()
    {
        AimTorch();
    }

    private void AimTorch()
    {
        var aimVec = controls.Player.MousePosition.ReadValue<Vector2>();

        var aimVecWorld = camera.ScreenToWorldPoint(new Vector3(aimVec.x, aimVec.y, 10.0f));
        Debug.Log(aimVecWorld);
        aimVecWorld = (Vector3)aimVecWorld - player.transform.position;
        var aimAngle = Mathf.Atan2(aimVecWorld.x, aimVecWorld.z) * 180 / Mathf.PI;
        player.transform.eulerAngles = new Vector3(player.transform.rotation.eulerAngles.x,aimAngle, player.transform.rotation.eulerAngles.z);
    }
}
