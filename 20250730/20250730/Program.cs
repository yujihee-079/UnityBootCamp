using System;
namespace CSharp
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            Knight,
            Mage,
            Rogue
        }

        enum MonsterType
        {
            none = 0,
            Slime,
            Orc,
            Skeleton
        }

        struct Player
        {
            public int hp;
            public int atk;
        }

        struct Monster
        {
            public int hp;
            public int atk;
        }

        static ClassType ClassChoice()
        {
            Console.WriteLine("직업을 선택하세요!");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 마법사");
            Console.WriteLine("[3] 도둑");

            ClassType choice = ClassType.None;
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Mage;
                    break;
                case "3":
                    choice = ClassType.Rogue;
                    break;
            }

            return choice;
        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
            // 기사(100/10), 마법사(50/15), 도둑(75/12)
            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.atk = 10;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.atk = 15;
                    break;
                case ClassType.Rogue:
                    player.hp = 75;
                    player.atk = 12;
                    break;
                default:
                    player.hp = 0;
                    player.atk = 0;
                    break;
            }
        }
        static void CreatRandomMonster(out Monster monster)
        {
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);

            switch (randMonster)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임이 스폰되었습니다.");
                    monster.hp = 20;
                    monster.atk = 2;
                    Console.WriteLine($"슬라임 HP {monster.hp} ATK {monster.atk}");
                    break;

                case (int)MonsterType.Orc:
                    Console.WriteLine("오크가 스폰되었습니다.");
                    monster.hp = 40;
                    monster.atk = 4;
                    Console.WriteLine($"오크 HP {monster.hp}  ATK {monster.atk}");
                    break;

                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤이 스폰되었습니다.");
                    monster.hp = 30;
                    monster.atk = 3;
                    Console.WriteLine($"스켈레톤 HP {monster.hp} ATK {monster.atk}");
                    break;
                default:
                    monster.hp = 0;
                    monster.atk = 0;
                    break;
                        }
        }


        static void EnterGame()
        {
            while (true)
            {
                Console.WriteLine("게임에 접속했습니다.");
                Console.WriteLine("[1] 사냥터로 이동");
                Console.WriteLine("[2] 로비로 돌아가기");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    EmterField();
                }
                else if (input == "2")
                {
                    break;
                }
            }
        }

        public static void EmterField()
        {
            while (true)
            {
                Console.WriteLine("사냥터에 도착했습니다.");

                Monster monster;
                CreatRandomMonster(out monster);

                Console.WriteLine("[1] 전투 시작");
                Console.WriteLine("[2] 도망 치기");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    //Fight();
                }

                else if (input == "2")
                {
                    continue;
                }
            }
        }


        static void Main(string[] args)
        {
            ClassType choice = ClassType.None;

            while (true)
            {
                choice = ClassChoice();
                if (choice != ClassType.None)
                {
                    Player player;
                    ClassType classType = ClassType.None;

                    // hp 셋팅
                    CreatePlayer(choice, out player);


                    Console.WriteLine($"HP {player.hp}, ATK {player.atk}");

                    EnterGame();
                }
            }
        }
    }
}

