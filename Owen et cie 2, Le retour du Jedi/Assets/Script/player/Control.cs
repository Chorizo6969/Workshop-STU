using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.InputSystem;

public class Control : MonoBehaviour
{
    public Vector3 mouvement;    
    internal Vector2 InputValue;
    public int speed;
    private float reloadTimerFisrtWeapon = 10;
    private float reloadTimeSecondWeapon = 10;
    public int killNeedForUlti = 8;

    [SerializeField] private bool isPrimaryWeaponFire;
    public float primaryWeaponRoloadCooldown;
    public int primaryWeaponSpread;

    [SerializeField] private bool isSecondaryWeaponFire;
    public float secondaryWeaponRoloadCooldown;
    public int secondaryWeaponSpread;

    public int secondWeaponId;
    public int UltId;

    private bool isStickUse = false;
    public GameObject primaryWeaponProjectile;
    public GameObject secondaryWeaponProjectile;
    public List<GameObject> projectilesList;
    public GameObject ultObject;
    public List<GameObject> ultObjectList;

    public GameObject lifeBar;

    private void Start()
    {
        switch (secondWeaponId)
        {
            case 0:
                secondaryWeaponProjectile = projectilesList[secondWeaponId];
                secondaryWeaponRoloadCooldown = 1;
                secondaryWeaponSpread = 40;
                break;

            case 1:
                secondaryWeaponProjectile = projectilesList[secondWeaponId];
                secondaryWeaponRoloadCooldown = 1.5f;
                secondaryWeaponSpread = 0;
                break;

            case 2:
                secondaryWeaponProjectile = projectilesList[secondWeaponId];
                secondaryWeaponRoloadCooldown = 1.5f;
                secondaryWeaponSpread = 0;
                break;
        }

        switch (UltId)
        {
            case 0:
                ultObject = ultObjectList[UltId]; 
                break;
            case 1:
                ultObject = ultObjectList[UltId];
                break;
        }
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
        if (callbackContext.started)
        {
            if (GetComponent<killCount>().ennemiKillCount >= killNeedForUlti)
            {
                GameObject _ult = Instantiate(ultObject);
                _ult.transform.position = transform.position;
                _ult.transform.parent = transform;
                GetComponent<killCount>().ennemiKillCount = 0;
            }
        }
    }

    private void FixedUpdate()
    {
        if (isStickUse)
        {
            transform.position = transform.position + (speed * mouvement * Time.deltaTime);
        }

        reloadTimerFisrtWeapon += Time.deltaTime;
        reloadTimeSecondWeapon += Time.deltaTime;
        if (isPrimaryWeaponFire)
        { 
            if (reloadTimerFisrtWeapon > primaryWeaponRoloadCooldown)
            {
                instantiateProjectil(primaryWeaponProjectile, primaryWeaponSpread);
                reloadTimerFisrtWeapon = 0;
            }
        }
        if (isSecondaryWeaponFire)
        {
            if (reloadTimeSecondWeapon > secondaryWeaponRoloadCooldown)
            {
                switch (secondWeaponId)
                {
                    case 0:
                        for (int i = 0; i < 10; i++)
                        {
                            instantiateProjectil(secondaryWeaponProjectile, secondaryWeaponSpread);
                        }
                        break;

                    case 1:
                        instantiateProjectil(secondaryWeaponProjectile, secondaryWeaponSpread);
                        break;

                    case 2:
                        instantiateMissile();
                        break;
                }
                reloadTimeSecondWeapon = 0;
            }
        }
    }

    public void instantiateProjectil(GameObject projectile, int _spread)
    {
        GameObject newBal = Instantiate(projectile);
        newBal.GetComponent<projectileMove>().spread = _spread;
        newBal.transform.position = transform.position;
    }
    private void instantiateMissile()
    {
        GameObject newMissile = Instantiate(secondaryWeaponProjectile);
        newMissile.transform.position = transform.position;
    }
}