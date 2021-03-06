using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpeedPW : MonoBehaviour {
    public float increase = 1.5f;

    private bool isUsed = false;

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.tag == "Player" && isUsed == false) {
            GameObject player = collision.gameObject;
            PlayerController playerScript = player.GetComponent<PlayerController>();
            GameObject boostEnable = GameObject.Find("UIEnable");
            UIEnable boostUI = boostEnable.GetComponent<UIEnable>();

            if (playerScript) {
                playerScript.ChangeMoveSpeed(increase);
                Destroy(gameObject);
                FindObjectOfType<AudioManager>().Play("Boost");

                boostUI.speedDestroyed = true;
            }

            isUsed = true;

        }

    }
}
