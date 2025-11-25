namespace ZombieSurvivalGame.Domain
{
    public class CharacterParts
    {

        // sundan ang role type
        public readonly static string[] RoleType =
        {
            "Human - A survivor trying to stay alive and avoid zombies.", "Zombie - A creature hunting humans to infect them."
        };

        // age
        public readonly static int[] Ages = { 15, 26, 41, 60 };
        public readonly static string[] AgeDescriptions = { "Fast and agile, making it easier to outrun zombies.", "Strong and balanced, good at both fighting and escaping.", "Experienced and calm, better at planning and spotting danger.", "Wise and cautious, gains bonuses for strategy and resource management." };

        public readonly static string[] EyeTypes =
        {
            "Almond",
            "Round",
            "Hooded",
            "Monolid"
        };

        // nose
        public readonly static string[] NoseTypes =
        {
            "Small",
            "Normal",
            "Flat",
            "Broken"
        };

        // mouth
        public readonly static string[] MouthTypes =
        {
            "Small",
            "Normal",
            "Wide",
            "Frown",
            "Smile"
        };


        // hairstyle
        public readonly static string[] HairStyleHuman =
        {
            "Straight",
            "Curly",
            "Messy",
            "Short",
            "Long"
        };

        public readonly static string[] HairStyleZombie =
        {
            "Thinning",
            "Patchy"
        };


        // body type
        public readonly static string[] BodyTypeHuman =
        {
            "Skinny",
            "Slim",
            "Normal",
            "Burly",
            "Bulk"
        };
        public readonly static string[] BodyTypeZombie =
        {

           "Decayed",
            "Bloated",
            "Hunched"
        };

        // skin color
        public readonly static string[] SkinColorHuman =
          {
            "Dark",
            "Light",
            "Brown",
            "Pale",
            "Tan"
        };

        public readonly static string[] SkinColorZombie =
        {
            "Gray",
            "Green",
            "Decayed",
            "Rotting"
        };

        // posture
        public readonly static string[] PostureTypeHuman =
        {
            "Upright",
            "Slouched",
            "LeaningForward",
            "Hunched",
            "Defensive",
        };

        public readonly static string[] PostureTypeZombie =
        {
            "Slouched",
            "Leaning Forward",
            "Hunched",
            "Casual",
            "Alert",
        };

        // shirt
        public readonly static string[] ShirtTypeHuman =
        {
            "TShirt",
            "Hoodie",
            "LongSleeve",
            "Ripped",
            "Military",
        };

        public readonly static string[] ShirtTypeZombie =
        {
            "Torn",
            "Dirty",
            "BloodStained",
        };

        // pants
        public readonly static string[] PantsTypeHuman =
        {
            "Jeans",
            "Cargo",
            "Shorts",
            "Tactical",
            "Ripped"
        };
        public readonly static string[] PantsTypeZombie =
        {
            "Dirty",
            "Torn",
            "Loose",
            "Decayed"
        };

        // weapon
        public readonly static string[] WeaponTypeHuman =
        {
            "Machete",
            "Axe",
            "Shotgun",
            "Handgun",
            "BaseballBat"
        };
        public readonly static string[] WeaponTypeZombie =
        {
            "Bite",
            "Claws"
        };

        // is stealthy
        public readonly static string[] IsStealthy =
        {
            "Yes - Your character moves quietly and avoids zombies more easily.",
            "No - Your character fights harder and deals more damage in combat."
        };
    }
}
