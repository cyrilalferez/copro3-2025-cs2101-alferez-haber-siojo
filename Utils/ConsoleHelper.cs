using ZombieSurvivalGame.Domain;

namespace ZombieSurvivalGame.Utils
{
    public class ConsoleHelper
    {
        public ConsoleHelper()
        {
        }

        public static void TypeEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);

                int delay = (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Spacebar) ? 0 : 30;

                //Thread.Sleep(delay);
            }

            Console.WriteLine();
        }


        public void MenuOptions()
        {
            Console.Clear();
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. Campaign Mode");
            Console.WriteLine("4. Credits");
        }

        // age
        public static void AgeOptions()
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            for (int i = 0; i < CharacterParts.Ages.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.Ages[i]} - {CharacterParts.AgeDescriptions[i]}");
            }
        }

        // role
        public static void CharacterRoleOptions()
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            for (int i = 0; i < CharacterParts.RoleType.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.RoleType[i]}");
            }
        }

        // eye
        public void EyeTypeOptions()
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            for (int i = 0; i < CharacterParts.EyeTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.EyeTypes[i]}");
            }
        }

        // nose
        public void NoseTypeOptions()
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            for (int i = 0; i < CharacterParts.NoseTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.NoseTypes[i]}");
            }
        }

        // mouth
        public void MouthTypeOptions()
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            for (int i = 0; i < CharacterParts.MouthTypes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {CharacterParts.MouthTypes[i]}");
            }
        }

        // hair style
        // Use role parameter instead of reading a possibly-null character
        public void HairStyleOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.HairStyleHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.HairStyleHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.HairStyleZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.HairStyleZombie[i]}");
                }
            }
        }

        // body type
        public void BodyTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.BodyTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.BodyTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.BodyTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.BodyTypeZombie[i]}");
                }
            }
        }

        // skin color
        public void SkinColorOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.SkinColorHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.SkinColorHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.SkinColorZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.SkinColorZombie[i]}");
                }
            }
        }

        // posture
        public void PostureOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.PostureTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.PostureTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.PostureTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.PostureTypeZombie[i]}");
                }
            }
        }

        // shirt
        public void ShirtTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human", StringComparison.OrdinalIgnoreCase))
            {
                for (int i = 0; i < CharacterParts.ShirtTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.ShirtTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.ShirtTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.ShirtTypeZombie[i]}");
                }
            }
        }

        // pants
        public void PantsTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human"))
            {
                for (int i = 0; i < CharacterParts.PantsTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.PantsTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.PantsTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.PantsTypeZombie[i]}");
                }
            }
        }

        // weapon
        public void WeaponTypeOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human"))
            {
                for (int i = 0; i < CharacterParts.WeaponTypeHuman.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.WeaponTypeHuman[i]}");
                }
            }
            else
            {
                for (int i = 0; i < CharacterParts.WeaponTypeZombie.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.WeaponTypeZombie[i]}");
                }
            }
        }

        // stealth perks
        public void StealthOptions(string role)
        {
            Console.WriteLine("========== CHARACTER CREATION ==========");
            if (role.Equals("Human"))
            {
                for (int i = 0; i < CharacterParts.IsStealthy.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {CharacterParts.IsStealthy[i]}");
                }
            }
        }
    }
}


