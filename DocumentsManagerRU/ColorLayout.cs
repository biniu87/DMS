using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentsManagerRU
{
    public class ColorLayout
    {
        public ColorLayout()
        {

        }

        public ColorLayout(Color foreground1, Color foreground2, Color background, Color objectButtons, Color selected)
        {
            COLOR_FORE_1 = foreground1;
            COLOR_FORE_2 = foreground2;
            COLOR_BACK = background;
            COLOR_OBJECTS = objectButtons;
            COLOR_SELECTED = selected;
            COLOR_PRESSED = GetColorFromRGB(197, 197, 197);
        }

        public ColorLayout(Color foreground1, Color foreground2, Color background, Color objectButtons, Color selected, string URLThumbnail)
        {
            COLOR_FORE_1 = foreground1;
            COLOR_FORE_2 = foreground2;
            COLOR_BACK = background;
            COLOR_OBJECTS = objectButtons;
            COLOR_SELECTED = selected;
            URL = URLThumbnail;
        }

        public ColorLayout(Color foreground1, Color foreground2, Color background, Color objectButtons, Color selected, string URLThumbnail, Image thumbnail)
        {
            COLOR_FORE_1 = foreground1;
            COLOR_FORE_2 = foreground2;
            COLOR_BACK = background;
            COLOR_OBJECTS = objectButtons;
            COLOR_SELECTED = selected;
            URL = URLThumbnail;
            THUMBNAIL = thumbnail;
        }

        public string URL;
        public Image THUMBNAIL;
        public Color COLOR_FORE_1 {get; set;}//0,0,0
        public Color COLOR_FORE_2 { get; set; }//255,255,255
        public Color COLOR_BACK { get; set; } //255,255,255
        public Color COLOR_OBJECTS { get; set; } //255,184,77,  251,228,152, 196, 226, 255
        public Color COLOR_PRESSED { get; set; } //197,197,197 - zawsze będzie stały
        public Color COLOR_SELECTED { get; set; } //70,72,60 / 0,70,138

        public void SetColorFromRGB(ColorLayoutController.ColorFields field, Color color)
        {
            switch (field)
            {
                case (ColorLayoutController.ColorFields.COLOR_FORE_1):
                    COLOR_FORE_1 = color;
                    break;
                case (ColorLayoutController.ColorFields.COLOR_FORE_2):
                    COLOR_FORE_2 = color;
                    break;
                case (ColorLayoutController.ColorFields.COLOR_BACK):
                    COLOR_BACK = color;
                    break;
                case (ColorLayoutController.ColorFields.COLOR_OBJECTS):
                    COLOR_OBJECTS = color;
                    break;
                case (ColorLayoutController.ColorFields.COLOR_SELECTED):
                    COLOR_SELECTED = color;
                    break;
                case (ColorLayoutController.ColorFields.COLOR_PRESSED):
                    COLOR_PRESSED = color;
                    break;
            }
        }

        public static Color GetColorFromRGB(int R, int G, int B)
        {
            return Color.FromArgb(((int)(((byte)(R)))), ((int)(((byte)(G)))), ((int)(((byte)(B)))));
        }
    }
}
