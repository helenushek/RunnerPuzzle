using System;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private RectTransform rect;
    [SerializeField] private Texture2D texture;
    [SerializeField] private MeshRenderer ball;

    [SerializeField] private Color red;
    [SerializeField] private Color blue;
    [SerializeField] private Color green;
    [SerializeField] private Color yellow;

    private string _color;

    private void Start()
    {
        _color = "red";
    }

    private void Update()
    {
        if (!Input.GetMouseButtonDown(0))
            return;

        if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(rect, Input.mousePosition, null,
                out Vector2 delta))
            return;

        delta += new Vector2(rect.rect.width * 0.5f, rect.rect.height * 0.5f);

        float x = delta.x / rect.rect.width;
        float y = delta.y / rect.rect.height;

        if (x < 0 || x > 1)
            return;
        if (y < 0 || y > 1)
            return;


        int texX = (int)(x * texture.width);
        int texY = (int)(y * texture.height);

        print($"{x} - {y}");

        Color color = texture.GetPixel(texX, texY);

        if (color.a < 0.8f)
            return;

        ball.material.color = color;

        ChangeColor(color);
    }

    private void ChangeColor(Color tsvet)
    {
        if (CompareColors(tsvet, red))
        {
            _color = "red";
        }

        else if (CompareColors(tsvet, blue))
        {
            _color = "blue";
        }

        else if (CompareColors(tsvet, green))
        {
            _color = "green";
        }

        else if (CompareColors(tsvet, yellow))
        {
            _color = "yellow";
        }

        else
        {
            _color = "none";
        }

        print($"{tsvet} - {blue} - {_color}");
    }

    bool CompareColors(Color color1, Color color2)
    {
        return
            CompareFloats(color1.r, color2.r) &&
            CompareFloats(color1.g, color2.g) &&
            CompareFloats(color1.b, color2.b);
    }

    bool CompareFloats(float float1, float float2)
    {
        return Math.Abs(float1 - float2) < 0.4f;
    }

    public string GetColor()
    {
        return _color;
    }
}