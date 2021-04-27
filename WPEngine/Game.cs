using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;

namespace WPEngine
{
    public class Game : GameWindow
    {
        private Game(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
           
        }

        public static Game Initialize(int width, int height, double renderFrequency, string title)
        {
            GameWindowSettings defaultGWS = GameWindowSettings.Default;
            NativeWindowSettings defaultNWS = NativeWindowSettings.Default;

            defaultGWS.RenderFrequency = renderFrequency;

            defaultNWS.Size = new Vector2i(width, height);
            defaultNWS.Title = title;

            return new Game(defaultGWS, defaultNWS);
        }
    }
}
