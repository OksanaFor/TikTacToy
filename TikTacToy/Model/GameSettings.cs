

namespace TikTacToy.Model
{
    public class GameSettings
    {
        private static GameSettings instance;

        public bool Easy { get; set; } = true;
        
        
        public static GameSettings Instance {
            get
            {
                if (instance == null)
                  instance = new GameSettings();
                return instance; 
            } 
        }
        private GameSettings()
        {

        }
        public static GameSettings GetInstance()
        {
            if (instance == null)
                instance = new GameSettings();
            return instance;
        }
    }
}