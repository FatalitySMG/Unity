using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clase
{
    public class Motor : MonoBehaviour
    {
        [SerializeField] float magnitud = 8, magAng = 450, t = 0, magDash = 500;
        [SerializeField] AudioClip idle, driving;
        AudioSource mAudio;
        Rigidbody mRig;
        void Start()
        {
            mAudio = GetComponent<AudioSource>();
            mRig = GetComponent<Rigidbody>();
        }
        void Update()
        {
            t += Time.deltaTime;     //Aca menciono una variable para contar tiempo
            //Direccion adelante, atras//
            Vector3 direccionz = transform.forward;
            float sentidoz = Input.GetAxis("Vertical");
            Vector3 velocidadz = magnitud * direccionz * sentidoz;
            Vector3 distanciaz = velocidadz * Time.deltaTime;
            transform.position = transform.position + distanciaz;

            //Direccion Derecha, Izquierda
            Vector3 direccionAng = new Vector3(0, 1, 0);
            float sentidoAng = Input.GetAxis("Horizontal");
            Vector3 velocidadAng = magAng * direccionAng * sentidoAng;
            Vector3 distanciaAng = velocidadAng * Time.deltaTime;
            transform.eulerAngles += distanciaAng;

            if (sentidoAng != 0 || sentidoz != 0)
            {
                mAudio.clip = driving;
                if (!mAudio.isPlaying) mAudio.Play();
            }
            else
            {
                mAudio.clip = idle;
                if (!mAudio.isPlaying) mAudio.Play();
            }

            //Prueba de Script
            if (t >= 7)
            {
                float sen = 1;
                Vector3 dash = transform.forward + transform.up;
                Vector3 force = magDash * dash * sen;

                if (Input.GetButtonDown("Jump"))
                {
                    mRig.AddForce(force);
                    t = 0;
                }
            public void Damage()
                 {
                     vida -= damage;
                 }

                 void OnCollisionStay(Collision collision)
                 {
                     if (collision.gameObject.tag == "Floor" && Input.GetButtonDown("Jump")) Salto();
                 }
            }           
        }
    }
}
