using KinematicCharacterController.Examples;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    private MyControls _myControls;

    private void Start()
    {
        _myControls = new MyControls();

        _myControls.MainCharacter.Movement.performed += context =>
        {
           
        };
    }


    private void Update()
    {
    }

    private void OnEnable()
    {
        _myControls.Enable();
    }

    private void OnDisable()
    {
        _myControls.Disable();
    }

}