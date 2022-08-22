using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initiateur_de_force : MonoBehaviour
{
    public Rigidbody2D RGBD;
    public float Puissance = 2f;
    public Vector2 Direction;
    // Start is called before the first frame update
    void Start()
    {
        RGBD.AddForce(Direction * Puissance, ForceMode2D.Force);
    }

}
