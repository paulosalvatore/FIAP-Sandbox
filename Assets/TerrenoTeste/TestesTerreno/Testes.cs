using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testes : MonoBehaviour
{
	public Terrain terreno;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Z))
		{
			AplicarMapa();
		}
	}

	private void AplicarMapa()
	{
		List<string> erros = new List<string>();

		using (var file = System.IO.File.OpenRead("C:/Kinect/Mapa.raw"))
		{
			using (var reader = new System.IO.BinaryReader(file))
			{
				int tamanho = 512;

				float[,] heights = terreno.terrainData.GetHeights(0, 0, tamanho, tamanho);

				for (int i = 0; i < tamanho; i++)
				{
					for (int j = 0; j < tamanho; j++)
					{
						try
						{
							float @byte = (float)reader.ReadInt16() / 65535;

							if (@byte < 0)
								@byte += 1;

							heights[i, j] = @byte;
						}
						catch (System.Exception)
						{
							erros.Add(string.Format("{0}, {1}", i, j));
						}
					}
				}

				if (erros.Count > 0)
					Debug.LogError("Bytes não encontrados: " + erros.Count);

				terreno.terrainData.SetHeights(0, 0, heights);
			}
		}
	}
}
