using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;

namespace MaxGrahamScan
{
    public class Vertex
    {
        public Vector2 position;
        public Color tint;

        public Vertex(Vector2 position)
        {
            this.position = position;
            tint = Color.Gray;
        }
    }

    public struct Edge
    {
        public Vertex from;
        public Vertex to;

        public Edge(Vertex from, Vertex to)
        {
            this.from = from;
            this.to = to;
        }
    }

    public class VertComparer : IComparer<Vertex>
    {
        Vector2 origin;

        public VertComparer(Vector2 origin) { this.origin = origin; }

        public int Compare(Vertex p0, Vertex p1)
        {
            float result = (p0.position.Y - origin.Y) * (p1.position.X - p0.position.X) - (p1.position.Y - p0.position.Y) * (p0.position.X - origin.X);

            if (result < 0.0f) return 1;
            else if (result > 0.0f) return -1;
            else return 0;
        }
    }

    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager gfx;
        SpriteBatch spriteBatch;

        //basic pixel object, can be scaled to form primitives
        Texture2D Pixel;
        //vertex image
        Texture2D vertex;

        const int TOP_BORDER = 200;
        const int WIDTH = 1000;
        const int HEIGHT = 1000;
        const int PADDING = 100;

        public enum Quadrant
        {
            TopRight,
            TopLeft,
            BottomLeft,
            BottomRight
        }

        List<Vertex> vertices;
        List<Edge> edges;

        Control controls;
        Random rand;

        public Game1()
        {
            gfx = new GraphicsDeviceManager(this);
            gfx.PreferredBackBufferHeight = HEIGHT + TOP_BORDER + (PADDING * 2);
            gfx.PreferredBackBufferWidth = WIDTH + (PADDING * 2);
            gfx.ApplyChanges();
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

            rand = new Random();
            
            Pixel = new Texture2D(GraphicsDevice, 1, 1);
            Pixel.SetData<Color>( new Color[] { Color.White } );

            vertex = Content.Load<Texture2D>("circle");

            vertices = new List<Vertex>();
            edges = new List<Edge>();

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

        public int checkOrientation(Vector2 p0, Vector2 p1, Vector2 p2)
        {
            float result = (p1.Y - p0.Y) * (p2.X - p1.X) - (p2.Y - p1.Y) * (p1.X - p0.X);

            if (result < 0.0f) return 1;
            else if (result > 0.0f) return -1;
            else return 0;
        }

        public void grahamScan(int delay = 0)
        {
            Vertex origin = vertices[0];
            int originIndex = 0;

            for (int i = 0; i < vertices.Count; i++)
            {
                if(vertices[i].position.Y > origin.position.Y || (vertices[i].position.Y == origin.position.Y && vertices[i].position.X < origin.position.X))
                {
                    origin = vertices[i];
                    originIndex = i;
                }
            }

            List<Vertex> remainingVertices = new List<Vertex>(vertices);

            Vertex temp = vertices[0];
            vertices[0] = vertices[originIndex];
            vertices[originIndex] = temp;
            
            VertComparer comp = new VertComparer(origin.position);
            vertices.Sort(1, vertices.Count - 1, comp);

            for(int i = 1; i < vertices.Count - 1; i++)
            {
                int result = checkOrientation(origin.position, vertices[i].position, vertices[i + 1].position);

                if (result == -1 && remainingVertices.Contains(vertices[i])) vertices[i].tint = Color.Green;
                else
                {
                    vertices[i].tint = Color.Red;
                    remainingVertices.Remove(vertices[i]);
                }

                if (delay != 0) System.Threading.Thread.Sleep(delay);
            }
            origin.tint = Color.Gold;
        }

        public Vector2 generateQuadPoint(Quadrant quad)
        {
            switch(quad)
            {
                case Quadrant.TopRight:
                    return new Vector2(rand.Next(WIDTH / 2, WIDTH) + PADDING, rand.Next(0, HEIGHT / 2) + TOP_BORDER + PADDING);

                case Quadrant.TopLeft:
                    return new Vector2(rand.Next(0, WIDTH / 2) + PADDING, rand.Next(0, HEIGHT / 2) + TOP_BORDER + PADDING);

                case Quadrant.BottomLeft:
                    return new Vector2(rand.Next(0, WIDTH / 2) + PADDING, rand.Next(HEIGHT / 2, HEIGHT) + TOP_BORDER + PADDING);

                case Quadrant.BottomRight:
                    return new Vector2(rand.Next(WIDTH / 2, WIDTH) + PADDING, rand.Next(HEIGHT / 2, HEIGHT) + TOP_BORDER + PADDING);
                default:
                    return new Vector2(0, 0);
            }
        }

        public void Generate(bool even, int n = 0)
        {
            vertices = new List<Vertex>();
            edges = new List<Edge>();

            Quadrant currentQuad = Quadrant.TopRight;

            if (n == 0) n = rand.Next(5, 101);
            for (int i = 0; i < n; i++)
            {
                if(even)
                {
                    Vector2 position = generateQuadPoint(currentQuad = (Quadrant)(((int)currentQuad + 1 )% 4));
                    vertices.Add(new Vertex(position));
                }
                else
                {
                    vertices.Add(new Vertex(new Vector2(rand.Next(0, WIDTH) + PADDING, rand.Next(0, HEIGHT) + TOP_BORDER + PADDING)));
                }
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
            GraphicsDevice.Clear(Color.PaleGreen);

            spriteBatch.Begin();

            spriteBatch.Draw(Pixel, new Rectangle(0, TOP_BORDER, WIDTH + (PADDING * 2), HEIGHT + (PADDING * 2)), Color.LightGray);
            spriteBatch.Draw(Pixel, new Rectangle(PADDING/2, TOP_BORDER + PADDING/2, WIDTH + PADDING, HEIGHT + PADDING), Color.White);

            for(int i = 0; i < vertices.Count; i++)
            {
                spriteBatch.Draw(vertex, vertices[i].position, vertices[i].tint);
            }

            spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
