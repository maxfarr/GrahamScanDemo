using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;

namespace MaxGrahamScan
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager gfx;
        SpriteBatch spriteBatch;

        //basic pixel object, can be scaled to form primitives
        Texture2D Pixel;

        struct Vertex
        {
            Point position;
            Color tint;

            public Vertex(int x, int y)
            {
                position = new Point(x, y);
                tint = Color.White;
            }
        }

        struct Edge
        {
            Vertex from;
            Vertex to;
        }

        List<Vertex> vertices;
        List<Edge> edges;

        Control controls;
        Random rand;

        public Game1()
        {
            gfx = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            Pixel = new Texture2D(GraphicsDevice, 1, 1);
            Pixel.SetData<Color>( new Color[] { Color.White } );


            controls = new Control(this);
            controls.Show();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        public void Generate(int n = 0)
        {
            if(n == 0)
            {
                for(int i = 0, count = rand.Next(5, 101); i < count; i++)
                {
                    vertices.Add(new Vertex());
                }
            }
            else
            {

            }
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            

            spriteBatch.Begin();

            spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
