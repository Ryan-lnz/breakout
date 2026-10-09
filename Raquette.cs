using System.Numerics;
using Raylib_cs;

namespace Breakout;

static partial class Program
{
    /// <summary>Le rectangle occupé par la raquette à l'écran.</summary>
    static Rectangle RectangleRaquette()
    {
        return new Rectangle(positionRaquette.X, positionRaquette.Y, LARGEUR_RAQUETTE, HAUTEUR_RAQUETTE);
    }

    /// <summary>Déplace la raquette avec les flèches, sans sortir de la fenêtre.</summary>
    static void DeplacerRaquette(float dt)
    {
        if (Raylib.IsKeyDown(KeyboardKey.Left))
        {
            positionRaquette.X = positionRaquette.X - (VITESSE_RAQUETTE * dt);
        }

       
        if (Raylib.IsKeyDown(KeyboardKey.Right))
        {
            positionRaquette.X = positionRaquette.X + (VITESSE_RAQUETTE * dt);
        }
    }

    /// <summary>Fait rebondir la balle si elle touche la raquette.</summary>
    static void RebondirSurRaquette()
    {
    }
}
