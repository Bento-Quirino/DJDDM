using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBoard : MonoBehaviour
{
    //Campo para o prefab do tile do tabuleiro
    public GameObject boardTile;
    public Vector3 offset;
    //numero de linhas e colunas, respectivamente
    public int height, width;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < height; i++)
        {
            for(int j = 0; j < width; j++)
            {
                Vector3 position = new Vector3(i, -j);
                position += offset;
                Instantiate(boardTile, position, Quaternion.identity);
            }
        }
    }
}
