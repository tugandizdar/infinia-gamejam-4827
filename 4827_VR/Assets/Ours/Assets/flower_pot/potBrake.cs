using UnityEngine;
using System.Collections;

namespace Valve.VR.InteractionSystem.Sample
{
    public class potBrake : MonoBehaviour
    {
        public GameObject explodePartPrefab;
        public int explodeCount = 10;

        public GameObject explodePartPrefab2;
        public int explodeCount2 = 10;

        public float minMagnitudeToExplode = 1f;

        private Interactable interactable;

        private void Start()
        {
            interactable = this.GetComponent<Interactable>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (interactable != null && interactable.attachedToHand != null) //don't explode in hand
                return;

            if (collision.impulse.magnitude > minMagnitudeToExplode)
            {
                for (int explodeIndex = 0; explodeIndex < explodeCount; explodeIndex++)
                {
                    GameObject explodePart = (GameObject)GameObject.Instantiate(explodePartPrefab, this.transform.position, this.transform.rotation);
                    explodePart.GetComponentInChildren<MeshRenderer>().material.SetColor("_TintColor", Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
                }

                for (int explodeIndex = 0; explodeIndex < explodeCount2; explodeIndex++)
                {
                    GameObject explodePart = (GameObject)GameObject.Instantiate(explodePartPrefab2, this.transform.position, this.transform.rotation);
                    explodePart.GetComponentInChildren<MeshRenderer>().material.SetColor("_TintColor", Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f));
                }

                Destroy(this.gameObject);
            }
        }
    }
}