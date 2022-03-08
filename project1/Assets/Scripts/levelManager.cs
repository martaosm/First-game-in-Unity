using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour
{
    private Transform _respawnPoint;
    private PlayerManager _player;

    // Start is called before the first frame update
    void Start()
    {
       // _respawnPoint = transform.Find("RespawnPoint");
        //_player = FindObjectOfType<PlayerManager>();
        //Respawn();
    }

    /*void Respawn()
    {
        _player.gameObject.SetActive(false);
        _player.transform.position = _respawnPoint.transform.position;
        _player.gameObject.SetActive(true);
    }*/
}
