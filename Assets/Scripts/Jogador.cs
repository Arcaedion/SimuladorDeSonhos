using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float Velocidade;
    public float ImpulsoPulo;
    public KeyCode ComandoDePulo;

    private bool _estaNoChao;

    void Update()
    {
        if (Input.GetKey(ComandoDePulo) && _estaNoChao)
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, ImpulsoPulo, 0), ForceMode.Impulse);
            _estaNoChao = false;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        _estaNoChao = true;
    }

    void FixedUpdate()
    {
        var corpo = GetComponent<Rigidbody>();
        corpo.velocity = new Vector3(Velocidade, corpo.velocity.y, corpo.velocity.z);
    }
}
