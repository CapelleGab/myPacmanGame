using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using myPacmanGame.Entities;

namespace myPacmanGame;

public class Game1 : Game
{
  private static Game1 _instance;
  private GraphicsDeviceManager _graphics;
  private SpriteBatch _spriteBatch;
  Entity playerEntity;


  public Game1()
  {
    _graphics = new GraphicsDeviceManager(this);
    Content.RootDirectory = "Content";
    IsMouseVisible = true;
    _instance = this;
  }

  public static Game1 GetInstance()
  {
    return _instance;
  }

  protected override void Initialize()
  {
    // Window size
    _graphics.PreferredBackBufferWidth = 1280;
    _graphics.PreferredBackBufferHeight = 720;
    _graphics.ApplyChanges();

    base.Initialize();
  }

  protected override void LoadContent()
  {
    _spriteBatch = new SpriteBatch(GraphicsDevice);
    playerEntity = new Entity(100, 150, "pacman", new Vector2(100, 100));

  }

  protected override void Update(GameTime gameTime)
  {
    if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
      Exit();

    playerEntity.Update(gameTime);

    base.Update(gameTime);
  }

  protected override void Draw(GameTime gameTime)
  {
    GraphicsDevice.Clear(Color.Black);

    _spriteBatch.Begin();
    playerEntity.Draw(_spriteBatch);
    _spriteBatch.End();

    base.Draw(gameTime);
  }
}
