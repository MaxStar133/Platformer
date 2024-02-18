using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CammeraController : MonoBehaviour
{
    [SerializeField] private GameObject Character;
    private Transform player;
    private void Awake()
    {
        {
            player=Character.transform.GetChild(ChangeCharacter.currentCharacter);
        }
    }

    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
