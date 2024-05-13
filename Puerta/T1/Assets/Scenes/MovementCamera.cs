using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Obtener la velocidad de rotación del giroscopio
        Quaternion gyroRotation = Input.gyro.attitude;

        // Invertir la rotación en el eje X
        gyroRotation.x = -gyroRotation.x;

        // Aplicar la rotación a la cámara
        transform.rotation = gyroRotation;
    }
}
