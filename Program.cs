using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pvp g1 = new Pvp("Торнадо", "\n Столкновения рассы людей с космическими шуруповёртами не избежать! Кого поддержишь ты? \n P.s. При создании игры ни один шуруповерт не пострадал.\n", 2023, "Ni?Er Studio", "12 months", 18,"Keyboard, Mouse, Imagination", 10);
            RPG g2 = new RPG("Cartel: La historia de un loco", "\n У Саймона копы забрали весь товар, картель уже выехал в поисках виновника,\n спасись или объяви войну мистеру Кредо, главе картеля 'Momento mori'!\n", 2023, "Quazar Studio", "125 часов удовольствия", 21, "Pentium 4, GPU 6GB, RAM 16gb, keyboard, mouse", "Боевой класс");
            SHT g3 = new SHT("Operation 'Black Diamond", "\n Дональд Дак не в состоянии защитить свое наследство от Дональда Трампа и взывает\n к помощи группу БiдOn, тысячи локаций, тысячи видов оружий, 4 компаньона и 5 противников!\n", 2019, "$по30 Studio","8 лет нескончаемого удовольствия", 99, "Good mental health, Jim Kerry, joystick", "Вид от первого лица") ;
            MOB g4 = new MOB("League of Leggings", "\n То, ради чего живут тысячи, то, что никогда не забудется, то, что заставляет вас думать\n о том, что то, о чем то не говорит никогда\n", 2002, "Vietnam Studio", "24/7", 12, "Станок для пошива, 4 вьетнамца, немного энтузиазма", "Гномы");
            STR g5 = new STR("Plastic Planet", "\n В 2427 году Практически не осталось пластика, корабли нашей расы остались без топлива для \n полетов к своим колониям и дружественным расам.\n Выход есть лишь один, найти планету пластика, которую отправили с Земли 170 лет назад, \n когда избавлялись от мусора!\n", 2130, "GreenP Studio", "170 часов геймплея в каждой компании", 14, "AMD 3890, Radeon 5900, 32 GB RAM, Keyboard, Mouse", "Пошаговая");
           
            Console.WriteLine("Введите цифру соответствующую типу понравившейся вам игры: \n 1. PVP(Player vs Player) \n 2. RPG(Role-Play Game) \n 3. Shooter \n 4. MOBA(Multiplayer Online Battle Arena) \n 5. Strategy");
            string input;
            int a;
            input = Console.ReadLine();
            a = Convert.ToInt32(input); //int transform from string

            if (a == 1)
            { 
                g1.MessagePvp();
            }
            if (a == 2)
            {
                g2.MessageRPG();
            }
            if (a == 3)
            {
                g3.MessageSHT();
            }
            if (a == 4)
            {
                g4.MessageMOB();
            }
            if (a == 5)
            {
                g5.MessageSTR();
            }
        }
    }
    class Pvp
    {
        public string Name;
        public string Description;
        public int Year;
        protected string _gameStudio;
        internal int MinAge;
        internal string TechnicalRequirements;
        internal string TimeGamePlay;
        private int _playersCount;

        public Pvp(string name, string description, int year, string gameStudio,  string timeGamePlay,int minAge, string technicalRequirements, int playersCount)
        {
            Name = name;
            Description = description;
            Year = year;
            _gameStudio = gameStudio;
            TechnicalRequirements = technicalRequirements;
            TimeGamePlay = timeGamePlay;
            MinAge = minAge;
            _playersCount = playersCount;

        }
        public void MessagePvp()
        {
            Console.WriteLine("Название: " + Name + "\n" + "Описание: " + Description + "\n" + "Студия: " + _gameStudio + "\n" + "Минимальный возраст: " + MinAge + "+" + "\n" + "Среднее время прохождения: " + TimeGamePlay + "\n" + "Технические характеристики: " + TechnicalRequirements + "\n" + "Максимальное колво игроков: " + _playersCount);
        }
    }
    class RPG
    {
        public string Name;
        public string Description;
        public int Year;
        protected string _gameStudio;
        internal int MinAge;
        private string _playerClass;
        internal string TechnicalRequirements;
        internal string TimeGamePlay;
        public RPG(string name, string description, int year, string gameStudio, string timeGamePlay, int minAge, string technicalRequirements, string playerClass)
        {
            Name = name;
            Description = description;
            Year = year;
            _gameStudio = gameStudio;
            TechnicalRequirements = technicalRequirements;
            TimeGamePlay = timeGamePlay;
            MinAge = minAge;
            _playerClass = playerClass;
        }
        public void MessageRPG()
        {
            Console.WriteLine("Название: " + Name + "\n" + "Описание: " + Description + "\n" + "Студия: " + _gameStudio + "\n" + "Минимальный возраст: " + MinAge + "+" + "\n" + "Среднее время прохождения: " + TimeGamePlay + "\n" + "Технические характеристики: " + TechnicalRequirements + "\n" + "Класс персонажа: " + _playerClass);
        }
    }
    class SHT
    {
        public string Name;
        public string Description;
        public int Year;
        protected string _gameStudio;
        internal int MinAge;
        internal string TechnicalRequirements;
        private readonly string _playerView;
        internal string TimeGamePlay;
        public SHT(string name, string description, int year, string gameStudio, string timeGamePlay, int minAge, string technicalRequirements, string playerView)
        {
            Name = name;
            Description = description;
            Year = year;
            _gameStudio = gameStudio;
            TechnicalRequirements = technicalRequirements;
            _playerView = playerView;
            TimeGamePlay = timeGamePlay;
            MinAge = minAge;
        }
        public void MessageSHT()
        {
            Console.WriteLine("Название: " + Name + "\n" + "Описание: " + Description + "\n" + "Студия: " + _gameStudio + "\n" + "Минимальный возраст: " + MinAge + "+" + "\n" + "Среднее время прохождения: " + TimeGamePlay + "\n" + "Технические характеристики: " + TechnicalRequirements + "\n" + "Тип обзора: " + _playerView);
        }
    }
    class MOB
    {
        public string Name;
        public string Description;
        public int Year;
        protected string _gameStudio;
        internal int MinAge;
        internal string TechnicalRequirements;
        private readonly string _playerRace;
        internal string TimeGamePlay;
        public MOB(string name, string description, int year, string gameStudio, string timeGamePlay, int minAge, string technicalRequirements, string playerRace)
        {
            Name = name;
            Description = description;
            Year = year;
            _gameStudio = gameStudio;
            TechnicalRequirements = technicalRequirements;
            _playerRace = playerRace;
            TimeGamePlay = timeGamePlay;
            MinAge = minAge;
        }
        public void MessageMOB()
        {
            Console.WriteLine("Название: " + Name + "\n" + "Описание: " + Description + "\n" + "Студия: " + _gameStudio + "\n" + "Минимальный возраст: " + MinAge + "+" + "\n" + "Среднее время прохождения: " + TimeGamePlay + "\n" + "Технические характеристики: " + TechnicalRequirements + "Расса игрока" + _playerRace);
 
        }
    }
    class STR
    {
        public string Name;
        public string Description;
        public int Year;

        protected string _gameStudio;
        internal int MinAge;
        internal string TechnicalRequirements;
        internal string TimeGamePlay;
        private string _gameType;
        public STR(string name, string description, int year, string gameStudio, string timeGamePlay, int minAge, string technicalRequirements, string gameType)
        {
            Name = name;
            Description = description;
            Year = year;
            _gameStudio = gameStudio;
            TechnicalRequirements = technicalRequirements;
            TimeGamePlay = timeGamePlay;
            MinAge = minAge;
            _gameType = gameType;
        }
        public void MessageSTR()
        {
            Console.WriteLine("Название: " + Name +
                "\n" + "Описание: " + Description + 
                "\n" + "Студия: " + _gameStudio + 
                "\n" + "Минимальный возраст: " + MinAge + "+" + 
                "\n" + "Среднее время прохождения: " + TimeGamePlay + 
                "\n" + "Технические характеристики: " + TechnicalRequirements +
                "\n" + "Тип стратегии: " + _gameType);
        }
    }
}

