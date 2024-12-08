using UnityEngine;

public class CubeMainScript : MonoBehaviour
{

    public string nameSecond = "Cube";
    public float Speed;
    [SerializeField] private int health;
    public Vector3 CubePosition;

    void Start()
    {
        this.gameObject.name = nameSecond;

        CubePosition = this.GetComponent<Transform>().position; 

        Debug.Log(CubePosition); 
    }

    void Update()
    {

    }

}