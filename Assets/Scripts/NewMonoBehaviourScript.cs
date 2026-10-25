using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public bool newBool = true;
    //my int
    public int newInt = 42;
    public int newInt2 = 0;
    [SerializeField] private int newInt3 = 0;

    //my float
    public float newFloat = 3.14f;
    [SerializeField] float newFloat2 = 0.0f;

    //my GameObject
    [SerializeField] private GameObject newGameObject;

    //my string
    [SerializeField] private string newString;
    [SerializeField] private string newString2 = "Hello World!";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
        Debug.Log(newInt3);

        Debug.Log("My current state of: " + newInt3);
        Debug.Log("My current state of: " + newInt3 + " and the " + newFloat2);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * (Time.deltaTime + newFloat2));
    }
}
