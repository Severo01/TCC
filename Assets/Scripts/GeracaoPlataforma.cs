using UnityEngine;

public class GeracaoPlataforma : MonoBehaviour
{
    public GameObject blocoPrefab;  // O prefab do bloco
    public Transform personagem;    // Referencia ao personagem
    public float distanciaGeracao = 20f;  // Distância mínima para gerar um novo bloco
    private Vector3 ultimaPosicao;  // última posição onde um bloco foi gerado
    private float posX;

    void Start()
    {
        ultimaPosicao = personagem.position;
        posX = transform.position.x;
        GerarBlocoInicial();
    }

    void Update()
    {
        if (posX - personagem.position.x <= distanciaGeracao)
        {
            GerarNovoBloco();       
        }
    }

    void GerarNovoBloco()
    {
        Vector3 novaPosicao = ultimaPosicao + new Vector3(1f, 0, 0);
        Instantiate(blocoPrefab, novaPosicao, Quaternion.identity);
        ultimaPosicao = novaPosicao;
        posX = novaPosicao.x;
    }

    void GerarBlocoInicial()
    {
        for (int i = -10; i < 20; i++) 
        {
            Vector3 pos = personagem.position + new Vector3(i * 1f, -2, 0);
            Instantiate(blocoPrefab, pos, Quaternion.identity);
            ultimaPosicao = pos;
            posX = pos.x;
        }
    }

}
