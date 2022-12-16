using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace InventoryManage
{
    public static class ThemeColor
    {
        public static  Color PrimaryColor{ get; set; }
        public static Color SecondaryColor { get; set; }

        public static List<string> ColorLisst = new List<string>() {    "#937DC2",
                                                                        "#790252",
                                                                        "#4C0033",
                                                                        "#8758FF",
                                                                        "#D2001A",
                                                                        "#5F6F94",
                                                                        "#367E18",
                                                                        "#F57328",
                                                                        "#CC3636",
                                                                        "#FF7777",
                                                                        "#D800A6",
                                                                        "#400D51",
                                                                        "#6F38C5",
                                                                        "#F96666",
                                                                        "#674747",
                                                                        "#829460",
                                                                        "#562B08",
                                                                        "#647E68",
                                                                        "#9C2C77",
                                                                        "#CD104D",
                                                                        "#E14D2A",
                                                                        "#937DC2",
                                                                        "#31C6D4",
                                                                        "#38E54D",
                                                                        "#FF577F",
                                                                        "#749F82",
                                                                        "#EA047E",
                                                                        "#FF6D28",
                                                                        "#815B5B",
                                                                        "#425F57",
                                                                        "#665A48",
                                                                        "#CF0A0A",
                                                                        "#54B435",
                                                                        "#379237",
                                                                        "#624F82",
                                                                        "#5F8D4E",
                                                                        "#10A19D",
                                                                        "#CB1C8D",
                                                                        "#439A97",
                                                                        "#7F167F"

                                                                        };
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            // If corection factor is less then 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red = red * correctionFactor;
                green = green * correctionFactor;
                blue = blue * correctionFactor;
            }

            // If corection factor is greater then 0, lighten color.
            else
            {
                red = (255 - red) * correctionFactor * red;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);

        }
    }
}
