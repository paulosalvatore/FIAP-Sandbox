using System.Collections;
using System.Collections.Generic;
using System.IO;

#if UNITY_EDITOR

using UnityEditor;

#endif

using UnityEngine;

public class Teste : MonoBehaviour
{
	/*
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.C))
			AlterarTextura();
	}

	private void AlterarTextura()
	{
		string path = "C:/Users/paulo/Desktop/Sandbox Kinect/Testes29-05-2017/terrenoTeste/Assets/Resources/";
		DirectoryInfo info = new DirectoryInfo(path);

		//FileInfo[] fileInfo = info.GetFiles();

		//AssetDatabase.Refresh();

		//if (fileInfo.Length <= 1)
		//	return;

		//FileInfo file = fileInfo[fileInfo.Length - 2];

		//string fileName = file.Name.Replace(file.Extension, "");

		Texture2D textura = Resources.Load("ImagemLimpa2") as Texture2D;

		string assetPath = AssetDatabase.GetAssetPath(textura);
		TextureImporter importer = (TextureImporter)TextureImporter.GetAtPath(assetPath);
		Debug.Log(importer);

		if (importer != null)
		{
			importer.isReadable = true;

			AssetDatabase.ImportAsset(assetPath, ImportAssetOptions.ForceUpdate);

			ApplyHeightmap(textura);
		}
	}

	public void ApplyHeightmap(Texture2D textura)
	{
		try
		{
			Undo.RegisterCompleteObjectUndo(Terrain.activeTerrain.terrainData, "Heightmap From Texture");

			TerrainData terrain = Terrain.activeTerrain.terrainData;
			int w = textura.width;
			int h = textura.height;
			int w2 = terrain.heightmapWidth;
			float[,] heightmapData = terrain.GetHeights(0, 0, w2, w2);
			Color[] mapColors = textura.GetPixels();
			Color[] map = new Color[w2 * w2];

			if (w2 != w || h != w)
			{
				// Resize using nearest-neighbor scaling if texture has no filtering
				if (textura.filterMode == FilterMode.Point)
				{
					float dx = float.Parse(w.ToString()) / w2;
					float dy = float.Parse(h.ToString()) / w2;
					for (int y = 0; y < w2; y++)
					{
						if (y % 20 == 0)
						{
							EditorUtility.DisplayProgressBar("Resize", "Calculating texture", Mathf.InverseLerp(0.0f, w2, y));
						}
						int thisY = int.Parse((dy * y).ToString()) * w;
						int yw = y * w2;
						for (int x = 0; x < w2; x++)
						{
							map[yw + x] = mapColors[int.Parse((thisY + dx * x).ToString())];
						}
					}
				}
				// Otherwise resize using bilinear filtering
				else
				{
					float ratioX = 1.0f / (float.Parse(w2.ToString()) / (w - 1));
					float ratioY = 1.0f / (float.Parse(w2.ToString()) / (h - 1));
					for (int y = 0; y < w2; y++)
					{
						if (y % 20 == 0)
						{
							EditorUtility.DisplayProgressBar("Resize", "Calculating texture", Mathf.InverseLerp(0.0f, w2, y));
						}
						float yy = Mathf.Floor(y * ratioY);
						float y1 = yy * w;
						float y2 = (yy + 1) * w;
						float yw = y * w2;
						for (int x = 0; x < w2; x++)
						{
							float xx = Mathf.Floor(x * ratioX);

							var bl = mapColors[int.Parse((y1 + xx).ToString())];
							var br = mapColors[int.Parse((y1 + xx + 1).ToString())];
							var tl = mapColors[int.Parse((y2 + xx).ToString())];
							var tr = mapColors[int.Parse((y2 + xx + 1).ToString())];

							float xLerp = x * ratioX - xx;
							map[int.Parse((yw + x).ToString())] = Color.Lerp(Color.Lerp(bl, br, xLerp), Color.Lerp(tl, tr, xLerp), y * ratioY - yy);
						}
					}
				}

				EditorUtility.ClearProgressBar();
			}
			else
			{
				map = mapColors;
			}

			for (int y = 0; y < w2; y++)
			{
				for (int x = 0; x < w2; x++)
				{
					heightmapData[y, x] = map[y * w2 + x].grayscale;
				}
			}

			terrain.SetHeights(0, 0, heightmapData);
		}
		catch (System.Exception)
		{
			throw;
		}
	}
	*/
}
