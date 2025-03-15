using System;

namespace Refresher.Concepts
{
    public enum PlayerState
    {
        Idle,
        Attacking
    }

    public class EnumExample
    {
        public static void ShowPlayerState(PlayerState state)
        {
            switch (state)
            {
                case PlayerState.Idle:
                    Console.WriteLine("Player is Idle");
                    break;
                case PlayerState.Attacking:
                    Console.WriteLine("Player is Attacking");
                    break;
            }
        }
    }
}