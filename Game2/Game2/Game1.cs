using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System;

namespace Game2
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        Texture2D Background;
        Texture2D Player;
        Texture2D Bullet;
        Vector2 BackgroundPos;
        Vector2 PlayerPos;
        Vector2 BulletPos;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Vector2 distance;

        List<Bullet> bullets = new List<Bullet>();

        float rotation;
        float BulletSpeed = 1f;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1200;
            graphics.PreferredBackBufferHeight = 900;
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
            Background = Content.Load<Texture2D>("GameBackground");
            Bullet = Content.Load<Texture2D>("Bullet");
            Player = Content.Load<Texture2D>("PlayerShip");
            PlayerPos = new Vector2(600, 800);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            MouseState mouse = Mouse.GetState();
            IsMouseVisible = true;

            distance.X = mouse.X - PlayerPos.X;
            distance.Y = mouse.Y - PlayerPos.Y;

            rotation = (float)Math.Atan2(distance.Y, distance.X)+ (float)Math.PI/2;

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                PlayerPos.Y -= 6;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                PlayerPos.X -= 6;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                PlayerPos.Y += 6;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                PlayerPos.X += 6;

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        public void UpdateBullet()
        {
            foreach(Bullet in bullets var)
            {
                Add.item(Bullet);
            }
        }

        public void Shoot()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
               
            }
           
        }



        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            spriteBatch
            
            spriteBatch.Draw(Background, BackgroundPos, Color.White);
            spriteBatch.Draw(Player, new Rectangle(PlayerPos.ToPoint(),new Point(75,75)),null,Color.White,rotation,new Vector2(Player.Width/2,Player.Height/2),SpriteEffects.None,0);
            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
