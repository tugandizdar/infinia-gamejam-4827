using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitTrigger : MonoBehaviour
{
    [SerializeField]
    GameObject exitdoor;
    
    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject trigger3;
    public GameObject trigger4;
    public GameObject trigger5;

    private Collider myCollider;

    private Collider myCollider1;
    private Collider myCollider2;
    private Collider myCollider3;
    private Collider myCollider4;
    private Collider myCollider5;

    // AudioSource bile�enini ekleyin
    AudioSource audioSource;

    //bool isOpened = false;
    void Start()
    {
        // AudioSource bile�enini al�n
        audioSource = GetComponent<AudioSource>();

        myCollider = this.GetComponent<Collider>();

    }

    void OnTriggerEnter(Collider col)
    {
        myCollider.isTrigger = false;

        myCollider1 = trigger1.GetComponent<Collider>();
        myCollider2 = trigger2.GetComponent<Collider>();
        myCollider3 = trigger3.GetComponent<Collider>();
        myCollider4 = trigger4.GetComponent<Collider>();
        myCollider5 = trigger5.GetComponent<Collider>();

        if (!myCollider1.isTrigger && !myCollider2.isTrigger && !myCollider3.isTrigger && !myCollider4.isTrigger && !myCollider5.isTrigger)
        {
            Debug.Log("Kapi Acildi.");
            //GameObject explodePart = (GameObject)GameObject.Instantiate(exitdoor, this.transform.position, this.transform.rotation);
            exitdoor.transform.position += new Vector3(0, 2f, 0);
            // Ses efektini �al�n
            //audioSource.Play();
        }
    }
}
