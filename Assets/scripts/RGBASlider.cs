using UnityEngine;

namespace Quest
{
    public class RGBASlider : MonoBehaviour
    {
        [SerializeField] private Color _myColor;

        private void OnGUI()
        {
            _myColor = RGBSlider(new Rect(10, 50, 200, 20), _myColor);
        }

        private Color RGBSlider(Rect screenRect, Color rgb)
        {
            rgb.r = LabelSlider(screenRect, rgb.r, 0.5f, 1.0f, "Red");
            screenRect.y += 20;
            rgb.g = LabelSlider(screenRect, rgb.g, 0.5f, 1.0f, "Green");
            screenRect.y += 20;
            rgb.b = LabelSlider(screenRect, rgb.b, 0.5f, 1.0f, "Blue");
            screenRect.y += 20;
            rgb.a = LabelSlider(screenRect, rgb.a, 0.5f, 1.0f, "Alpha");
            return rgb;
        }

        private float LabelSlider(Rect screenRect, float sliderValue, float sliderMinValue, float sliderMaxValue,
            string labelText)
        {
            GUI.Label(screenRect, labelText);
            screenRect.x += screenRect.width;
            sliderValue = GUI.HorizontalSlider(screenRect, sliderValue, 0.0f,
                sliderMaxValue);
            return sliderValue;

        }
    }
}