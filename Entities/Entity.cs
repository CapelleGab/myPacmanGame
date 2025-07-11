using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace myPacmanGame.Entities;

public class Entity
{
  // Content manager to load textures
  private readonly ContentManager _contentManager;

  // Entity properties
  private float _health;
  private readonly float _speed;
  private Texture2D _texture;
  private Vector2 _position;
  private float _rotation;

  public Entity(float health, float speed, string texturePath, Vector2 position)
  {
    _health = health;
    _speed = speed;
    _contentManager = Game1.GetInstance().Content;
    _texture = LoadTextureFromPath(texturePath);
    _position = position;
    _rotation = 0f;
  }

  private Texture2D LoadTextureFromPath(string texturePath)
  {
    return _contentManager.Load<Texture2D>(texturePath);
  }

  public void Draw(SpriteBatch spriteBatch)
  {
    spriteBatch.Draw(_texture, new Rectangle((int)_position.X, (int)_position.Y, 50, 50), null, Color.White, _rotation, new Vector2(_texture.Width / 2f, _texture.Height / 2f), SpriteEffects.None, 0f);
  }

  public void Update(GameTime gameTime)
  {
    var keyboard = Keyboard.GetState();
    float delta = (float)gameTime.ElapsedGameTime.TotalSeconds;

    if (keyboard.IsKeyDown(Keys.Up))
    {
      _position.Y -= _speed * delta;
      _rotation = 3f * MathF.PI / 2f;
    }
    else if (keyboard.IsKeyDown(Keys.Down))
    {
      _position.Y += _speed * delta;
      _rotation = MathF.PI / 2f;
    }
    else if (keyboard.IsKeyDown(Keys.Left))
    {
      _position.X -= _speed * delta;
      _rotation = MathF.PI;
    }
    else if (keyboard.IsKeyDown(Keys.Right))
    {
      _position.X += _speed * delta;
      _rotation = 0f;
    }
  }

  public float GetHealth()
  {
    return _health;
  }

  public void SetHealth(float health)
  {
    _health = health;
  }

  public float GetSpeed()
  {
    return _speed;
  }
  public Texture2D GetTexture()
  {
    return _texture;
  }

  public void SetTexture(Texture2D texture)
  {
    _texture = texture;
  }
  public Vector2 GetPosition()
  {
    return _position;
  }

  public void SetPosition(Vector2 position)
  {
    _position = position;
  }





}