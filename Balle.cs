using System.Numerics;

namespace Breakout;

static partial class Program
{
    /// <summary>Pose la balle au milieu du dessus de la raquette.</summary>
    static void CollerBalleARaquette()
    {
        positionBalle.X = positionRaquette.X + (LARGEUR_RAQUETTE / 2f);
        positionBalle.Y = positionRaquette.Y - RAYON_BALLE;
    }

    /// <summary>Donne à la balle sa vitesse de départ.</summary>
    static void LancerBalle()
    {
        vitesseBalle.X = VITESSE_BALLE * 0.7071f;
        vitesseBalle.Y = -VITESSE_BALLE * 0.7071f;
    }

    /// <summary>Avance la balle selon sa vitesse.</summary>
    static void DeplacerBalle(float dt)
    {
       
        positionBalle += vitesseBalle * dt;
    }

    /// <summary>Fait rebondir la balle sur les murs gauche, droit et haut.</summary>
    static void RebondirSurMurs()
    {
        if (positionBalle.X - RAYON_BALLE < 0)
        {
            positionBalle.X = RAYON_BALLE;
            vitesseBalle.X = -vitesseBalle.X;


            if (positionBalle.X + RAYON_BALLE > LARGEUR)
            {
                positionBalle.X = LARGEUR - RAYON_BALLE;
                vitesseBalle.X = -vitesseBalle.X;


                if (positionBalle.Y - RAYON_BALLE < 0)
                {
                    positionBalle.Y = RAYON_BALLE;
                    vitesseBalle.Y = -vitesseBalle.Y;
                }
            }

            /// <summary>Indique si la balle est entièrement sortie par le bas de la fenêtre.</summary>
            static bool BalleSortieEnBas()
            {
                return false;
            }
        }
    }
}
   
