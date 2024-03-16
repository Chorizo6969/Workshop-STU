using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

public class Ending : MonoBehaviour
{
    [SerializeField] private GameObject panel_victory;
    [SerializeField] private PlayerInput _playerInput;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            _playerInput.SwitchCurrentActionMap("MenuActionMap");
            panel_victory.SetActive(true);
            //Time.timeScale = 0; ;
        }
    }
}
