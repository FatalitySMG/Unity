
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


{
    public class edificio : MonoBehaviour
    {
        [SerializeField] float vida = 100;
        [SerializeField] motorSantiago tanque;
        
        void Update()
        {
            if(vida == 0) Destroy(gameObject);
        }

        public void Damage()
        {
            vida -= tanque.damage / 2;
        }
    }
}
