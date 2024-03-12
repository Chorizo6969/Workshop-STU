using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.InputSystem;

public class Control : MonoBehaviour
{
    internal Vector2 InputValue;
    public int speed;
    private float currenttime1;
    private float currenttime2;

    private bool isPrimaryWeaponFire;
    public float primaryWeaponRoloadCooldown;
    public int primaryWeaponSpread;

    private bool isSecondaryWeaponFire;
    public float secondaryWeaponRoloadCooldown;
    public int secondaryWeaponSpread;

    public int secondWeaponId;

    private bool isStickUse = false;
    public GameObject primaryWeaponProjectile;
    public GameObject secondaryWeaponProjectile;
    public List<GameObject> projectilesList;
    
    public Vector3 mouvement;

    private void Start()
    {
        secondaryWeaponProjectile = projectilesList[secondWeaponId];
    }

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
        if (callbackContext.started)
        {
            isSecondaryWeaponFire = true;
        }
        if (callbackContext.canceled)
        {
            isSecondaryWeaponFire = false;
        }
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

        currenttime1 += Time.deltaTime;
        currenttime2 += Time.deltaTime;
        if (isPrimaryWeaponFire)
        { 
            if (currenttime1 > primaryWeaponRoloadCooldown)
            {
                instantiateProjectil(primaryWeaponProjectile, primaryWeaponSpread);
                currenttime1 = 0;
            }
        }
        if (isSecondaryWeaponFire)
        {
            if (currenttime2 > secondaryWeaponRoloadCooldown)
            {
                if (secondWeaponId == 0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        instantiateProjectil(secondaryWeaponProjectile, secondaryWeaponSpread);
                    }

                }
                currenttime2 = 0;
            }
        }
    }

    private void instantiateProjectil(GameObject projectile, int _spread)
    {
        GameObject newBal = Instantiate(projectile);
        newBal.GetComponent<projectileMove>().spread = _spread;
        newBal.transform.position = transform.position;
    }
}
