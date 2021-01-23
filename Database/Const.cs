﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Database
{
    public static class Const
    {
        public static string Host { get; } = "rogue.db.elephantsql.com";
        public static string User { get; } = "hxsncoqk";
        public static string Pass { get; } = "XaZ8iDDa0PccwESDkH7g9zxwVMT4jdYp";
        public static string DBName { get; } = "hxsncoqk";

        public static ColorTheme Dark { get; set; } 
        public static ColorTheme Light { get; set; }

        static Const()
        {
            var lightbg = Color.FromArgb(220, 220, 220);
            var lightfont = Color.FromArgb(30, 30, 30);
            var lightccolor = Color.FromArgb(207, 207, 207);
            var lightcfont = Color.FromArgb(15, 15, 15);

            Light = new ColorTheme(lightccolor, lightcfont, lightbg, lightfont);

            var darkbg = Color.FromArgb(220, 220, 220);
            var darkfont = Color.FromArgb(30, 30, 30);
            var darkccolor = Color.FromArgb(207, 207, 207);
            var darkcfont = Color.FromArgb(15, 15, 15);

            Dark = new ColorTheme(darkccolor, darkcfont, darkbg, darkfont);
        }
    }

    public class ColorTheme
    {
        public Color ControlColor { get; set; }
        public Color Background { get; set; }
        public Color ControlFontColor { get; set; }
        public Color MainFontColor { get; set; }

        public ColorTheme(Color ccolor, Color cfontcolor, Color bgcolor, Color mainfontcolor)
        {
            ControlColor = ccolor;
            Background = bgcolor;
            ControlFontColor = cfontcolor;
            MainFontColor = mainfontcolor;
        }

        public void ApplyTo(Form form)
        {
            form.BackColor = Background;
            form.ForeColor = MainFontColor;

            foreach(var c in form.Controls)
            {
                if(c.GetType() == typeof(Button))
                {
                    (c as Button).BackColor = ControlColor;
                    (c as Button).ForeColor = ControlFontColor;
                }
            }
        }
    }
}
