using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationtorret : MonoBehaviour
{
    [SerializeField] float magAng = 360;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccionAng = new Vector3(0, 1, 0);
        float sentidoAng = Input.GetAxis("RotTorret");
        Vector3 velocidadAng = magAng * direccionAng * sentidoAng;
        Vector3 distanciaAng = velocidadAng * Time.deltaTime;
        transform.eulerAngles += distanciaAng;
    }
}
