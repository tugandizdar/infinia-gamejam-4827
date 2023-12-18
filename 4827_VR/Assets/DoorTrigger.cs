using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    // AudioSource bile�enini ekleyin
    AudioSource audioSource;

    bool isOpened = false;
    void Start()
    {
        // AudioSource bile�enini al�n
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("girdi");
        if (!isOpened)
        {
            isOpened = true;
            door.transform.position += new Vector3(0, 0.5f, 0);

            // Ses efektini �al�n
            audioSource.Play();
        }
    }
}
