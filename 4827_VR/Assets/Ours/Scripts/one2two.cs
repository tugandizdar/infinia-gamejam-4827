using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem
{
public class one2two : MonoBehaviour
{
        public LinearMapping linearMappingLeft;
        public LinearMapping linearMappingRight;
        public GameObject myGameObject;

        private float valueLeft;
        private float valueRight;

		void Update()
		{
            valueLeft = (linearMappingLeft.value - 0.5f)*20.0f;
            valueRight = (linearMappingRight.value - 0.5f)*20.0f;

            myGameObject.transform.rotation = Quaternion.Euler(-valueLeft-valueRight, 0.0f, valueLeft-valueRight);
		}
}
}