using ZombieSurvivalGame.Config;
using ZombieSurvivalGame.Model;

namespace ZombieSurvivalGame.Data
{
    internal class CharacterRepository
    {
        // save character
        // NOTE: Update the Character table
        public void SaveCharacter(Character character)
        {
            try
            {
                using (var conn = new SqliteDatabase().CreateConnection())
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                            INSERT INTO Characters 
                            (Role, Name, Age, EyeType, NoseType, MouthType, HairStyle, BodyType, SkinColor, Posture, Shirt, Pants, Weapon, IsStealthy) 
                            VALUES 
                            (@Role, @Name, @Age, @EyeType, @NoseType, @MouthType, @HairStyle, @BodyType, @SkinColor, @Posture, @Shirt, @Pants, @Weapon, @IsStealthy);
                        ";
                        cmd.Parameters.AddWithValue("@Role", character.Role);
                        cmd.Parameters.AddWithValue("@Name", character.Name);
                        cmd.Parameters.AddWithValue("@Age", character.Age);
                        cmd.Parameters.AddWithValue("@EyeType", character.Eye);
                        cmd.Parameters.AddWithValue("@NoseType", character.Nose);
                        cmd.Parameters.AddWithValue("@MouthType", character.Mouth);
                        cmd.Parameters.AddWithValue("@HairStyle", character.HairStyle);
                        cmd.Parameters.AddWithValue("@BodyType", character.Body);
                        cmd.Parameters.AddWithValue("@SkinColor", character.Skin);
                        cmd.Parameters.AddWithValue("@Posture", character.Posture);
                        cmd.Parameters.AddWithValue("@Shirt", character.Shirt);
                        cmd.Parameters.AddWithValue("@Pants", character.Pants);
                        cmd.Parameters.AddWithValue("@Weapon", character.Weapon);
                        cmd.Parameters.AddWithValue("@IsStealthy", character.IsStealthy);
                        cmd.ExecuteNonQuery();
                    }

                    Console.WriteLine("Character Created!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in saving character: " + e.Message);
            }
        }

        // load character
        // NOTE: Update the Character table
        public List<Character> LoadCharacters()
        {
            List<Character> characters = new List<Character>();
            try
            {
                using (var conn = new SqliteDatabase().CreateConnection())
                {
                    conn.Open();
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Characters;";
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Character character = new Character(
                                    reader.GetString(reader.GetOrdinal("Role")),
                                    reader.GetString(reader.GetOrdinal("Name")),
                                    reader.GetInt32(reader.GetOrdinal("Age")),
                                    reader.GetString(reader.GetOrdinal("EyeType")),
                                    reader.GetString(reader.GetOrdinal("NoseType")),
                                    reader.GetString(reader.GetOrdinal("MouthType")),
                                    reader.GetString(reader.GetOrdinal("HairStyle")),
                                    reader.GetString(reader.GetOrdinal("BodyType")),
                                    reader.GetString(reader.GetOrdinal("SkinColor")),
                                    reader.GetString(reader.GetOrdinal("Posture")),
                                    reader.GetString(reader.GetOrdinal("Shirt")),
                                    reader.GetString(reader.GetOrdinal("Pants")),
                                    reader.GetString(reader.GetOrdinal("Weapon")),
                                    reader.GetInt32(reader.GetOrdinal("IsStealthy")) == 1
                                );
                                characters.Add(character);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in loading characters: " + e.Message);
            }
            return characters;
        }
    }
}
