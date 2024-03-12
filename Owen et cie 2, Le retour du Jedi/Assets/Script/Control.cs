using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.InputSystem;

public class Control : MonoBehaviour
{
    internal Vector2 InputValue;
    public int speed;

    public bool isPrimaryWeaponFire;
    public float currenttime;
    public float primaryWeaponRoloadCooldown;

    public bool isStickUse = false;
    public GameObject primaryWeaponProjectil;
    
    public Vector3 mouvement;

    public void OnMoove(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            isStickUse = true;
        }
        if(callbackContext.canceled)
        {
            isStickUse = false;
        }
        Vector2 orientation = callbackContext.ReadValue<Vector2>();
        mouvement = new Vector3(InputValue.x, 0, InputValue.y);
        mouvement.x += orientation.x;
        mouvement.y += orientation.y;
        mouvement.z = 0;
        mouvement.Normalize();
        
    }

    public void OnShootWithPrimaryWeapon(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.started)
        {
            isPrimaryWeaponFire = true;
        }
        if (callbackContext.canceled)
        {
            isPrimaryWeaponFire = false;
        }
    }

    public void OnShootWithSecondaryWeapon(InputAction.CallbackContext callbackContext)
    {

    }

    public void OnUltime(InputAction.CallbackContext callbackContext)
    {

    }

    private void FixedUpdate()
    {
        if (isStickUse)
        {
            transform.position = transform.position + (speed * mouvement * Time.deltaTime);
        }

        currenttime += Time.deltaTime;
        if (isPrimaryWeaponFire)
        { 
            if (currenttime > primaryWeaponRoloadCooldown)
            {
                instantiateProjectil();
                currenttime = 0;
            }
        }
    }

    private void instantiateProjectil()
    {
        GameObject newBal = Instantiate(primaryWeaponProjectil);
        newBal.transform.position = transform.position;
    }
}
