﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Checkpoints : MonoBehaviour
{
    [Header ("Checkpoints")]
    public GameObject[] Checkpoint;

    [Header ("Tags")]
    public string TagToDie;
    public string CheckpointTag;
    private bool FoundCP;
    [Header ("Do you want to be set to the latest checkpoint at the start?")]
    [Header("Möchtest du beim Start auf den letzten Checkpoint gesetzt werden?")]
    public bool GotoLatestChackpointOnStart;
    [Header ("Message")]
    [Header("Nachricht anzeigen")]
    public bool ShowMessage;
    public GameObject MessagePanel;
    public float Duration;
    private float Timer;
    [Header ("Sounds")]
    [Header("Sound abspielen")]
    public bool PlaySound;
    public AudioSource Sound;

    void Update()
    {
        if (ShowMessage)
        {
            if (Timer <= 0)
            {
                MessagePanel.SetActive(false);
            }
            else
                Timer -= Time.deltaTime;
        }
    }

    void Start()
    {
        if (GotoLatestChackpointOnStart)
        {
            for (int i = 0; i < Checkpoint.Length; i++)
            {
                if (PlayerPrefs.GetInt("Checkpoint" + Checkpoint[i] + "active") == 1)
                {
                    transform.position = Checkpoint[i].transform.position;
                    Debug.Log("Zurück gesetzt zu  " + Checkpoint[i]);
                    break;
                }

            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == TagToDie)
        {
            GotoLatestCheckpoint();
            Debug.Log("Zuruck zum Checkpoint");

        }

        if (collision.collider.tag == CheckpointTag)
        {
            SetActiveCheckpoint(System.Array.IndexOf(Checkpoint, collision.gameObject));
            if (PlaySound)
            {
                Sound.Play();
            }

            if (ShowMessage)
            {
                MessagePanel.SetActive(true);
                Timer = Duration;
            }
        }
    }

    public void Die()
    {
        GotoLatestCheckpoint();
    }

    public void SetActiveCheckpoint(int CP)
    {
        for (int i = 0; i < Checkpoint.Length; i++)
        {
            if (i == CP)
            {
                PlayerPrefs.SetInt("Checkpoint" + Checkpoint[i] + "active", 1);
                Debug.Log("Checkpoint " + Checkpoint[i] + "erreicht!");
            }
            else
            PlayerPrefs.SetInt("Checkpoint" + Checkpoint[i] + "active", 0);
        }
    }

    public void GotoLatestCheckpoint()
    {
        FoundCP = false;
        for (int i = 0; i < Checkpoint.Length; i++)
        {
            if (PlayerPrefs.GetInt("Checkpoint" + Checkpoint[i] + "active") == 1)
            {
                transform.position = Checkpoint[i].transform.position;
                Debug.Log("Zurück gesetzt zu  " + Checkpoint[i]);
                FoundCP = true;
                break;
            }
            
        }

        if (FoundCP == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
