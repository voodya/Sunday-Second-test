using UnityEngine;
using UnityEngine.UI;

public class ColoredAndRotate : MonoBehaviour
{
    [SerializeField] private Slider _x;
    [SerializeField] private Slider _y;
    [SerializeField] private Slider _z;


    [SerializeField] private Button _colorSwich;

    private Rigidbody rb;
    private Material mat;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mat = rb.GetComponent<Renderer>().material;
        _colorSwich.onClick.AddListener(RandomColor);
    }

    private void RandomColor()
    {
        mat.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
    }

    private void FixedUpdate()
    {
        rb.angularVelocity = new Vector3(_x.value, _y.value, _z.value);
    }
}
