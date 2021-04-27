using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;
using OpenTK.Graphics.ES30;
using WPEngine.Common;
using OpenTK.Windowing.Common;

namespace WPEngine
{
    public class Game : GameWindow
    {
        private Common.Shader _shader;
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

        protected override void OnLoad()
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            GL.Enable(EnableCap.DepthTest);
            _shader = new Shader("Utils/shader.vert", "Utils/shader.frag");
            _shader.Use();

            //Load stuff

            base.OnLoad();
        }

        protected override void OnUnload()
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);
            GL.BindVertexArray(0);
            GL.UseProgram(0);

            //Unload stuff

            GL.DeleteProgram(_shader.Handle);
            base.OnUnload();
        }

        protected override void OnRenderFrame(FrameEventArgs args)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            //Render stuff

            SwapBuffers();
            base.OnRenderFrame(args);
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {

            //Update stuff

            base.OnUpdateFrame(args);
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            GL.Viewport(0, 0, e.Width , e.Height);
            base.OnResize(e);
        }

    }
}
