using System;

namespace TextRPG
{
    internal class Program
    {
        enum Jobs
        {
            None = 0,
            Knight,
            Mage,
            Assassin
        }

        struct Player
        {
            public int STAGE;
            public int LEVEL;
            public int HP;
            public int MHP;
            public int ATK;
            public int EX;
            public int MEX;
            public string Name;
            public int Ult;
            public bool IsAlive;
        }

        struct Monster
        {
            public int HP;
            public int MHP;
            public int ATK;
            public string Name;
        }

        static Jobs ChoiceJob()
        {
            Jobs Choice = Jobs.None;
            Console.Clear();
            Console.WriteLine("\n직업을 선택해주세요");
            Console.WriteLine("[1] 전사\t(HP : 100, ATK : 10)\n[2] 마법사\t(HP : 50, ATK : 20)\n[3] 도적\t(HP : 75, ATK : 15)");

            string temp = Console.ReadLine();
            Console.WriteLine();
            switch (temp)
            {
                case "1":
                    Choice = Jobs.Knight;
                    Console.WriteLine("전사를 선택했습니다.");
                    break;
                case "2":
                    Choice = Jobs.Mage;
                    Console.WriteLine("마법사를 선택했습니다.");
                    break;
                case "3":
                    Choice = Jobs.Assassin;
                    Console.WriteLine("도적을 선택했습니다.");
                    break;
                default:
                    break;
            }
            return Choice;
        }

        static void SetPlayer(Jobs job, out Player player)
        {
            switch (job)
            {
                case Jobs.Knight:
                    player.HP = 100;
                    player.ATK = 10;
                    break;
                case Jobs.Mage:
                    player.HP = 50;
                    player.ATK = 20;
                    break;
                case Jobs.Assassin:
                    player.HP = 75;
                    player.ATK = 15;
                    break;
                default :
                    player.HP = 0;
                    player.ATK = 0;
                    break;
            }
            player.STAGE = 1;
            player.LEVEL = 1;
            player.MHP = player.HP;
            player.EX = 0;
            player.MEX = 100;
            player.Ult = 0;
            player.Name = "";
            player.IsAlive = true;
        }

        static void SetMonster(out Monster monster)
        {
            Random random = new Random();
            int random_M = random.Next(1, 6);
            switch (random_M)
            {
                case 1:
                    monster.HP = 30;
                    monster.ATK = 5;
                    monster.Name = "좀비";
                    break;
                case 2:
                    monster.HP = 50;
                    monster.ATK = 2;
                    monster.Name = "바퀴벌레";
                    break;
                case 3:
                    monster.HP = 11;
                    monster.ATK = 10;
                    monster.Name = "장수말벌";
                    break;
                case 4:
                    monster.HP = 25;
                    monster.ATK = 7;
                    monster.Name = "스켈레톤";
                    break;
                case 5:
                    monster.HP = 20;
                    monster.ATK = 8;
                    monster.Name = "늑대";
                    break;
                default:
                    monster.HP = 0;
                    monster.ATK = 0;
                    monster.Name = "";
                    break;
            }
            monster.MHP = monster.HP;
        }

        static void GameStop()
        {
            Console.WriteLine("계속 하려면 아무키나 누르십시오.");
            Console.ReadKey();
        }

        static Player LevelUp(Player player)
        {
            player.LEVEL++;
            player.HP += 20;
            player.MHP += 20;
            player.ATK += 5;
            player.MEX += 10;

            Console.WriteLine($"레벨업 했습니다! 현재 레벨 : {player.LEVEL}");
            Thread.Sleep(1000);

            return player;
        }

        static bool Menu(ref Player player, ref Monster monster)
        {
            bool run=false;
            string UltP= "";
            int tempUlt = player.Ult;
            for (int i = 0; i < 5; i++)
            {
                if(tempUlt > 0)
                {
                    UltP += "■";
                    tempUlt--;
                }
                else
                {
                    UltP += "□";
                }
            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"=================================================== [ {player.STAGE} 스테이지 ] =================================================== ");
            Console.WriteLine();
            Console.WriteLine($"==================================================== [ {player.Name} ] ====================================================");
            Console.WriteLine($"========================== [ Level : {player.LEVEL} ]   [ HP : {player.HP}/{player.MHP} ]   [ ATK : {player.ATK} ]   [ EX : {player.EX}/{player.MEX} ] ==========================");
            Console.WriteLine($"======================================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"==================================================== [ {monster.Name} ] ====================================================");
            Console.WriteLine($"=========================================== [ HP : {monster.HP}/{monster.MHP} ]  [ ATK : {monster.ATK} ] ===========================================");
            Console.WriteLine($"======================================================================================================================");
            Console.WriteLine();
            Console.WriteLine($"==================================================== 궁극기포인트 ====================================================");
            Console.WriteLine($"===================================================== {UltP} =====================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============== 1. 공격");
            Console.WriteLine("============== 2. 궁극기(5 포인트 필요)");
            Console.WriteLine("============== 3. 도망가기");
            Console.WriteLine();
            Console.Write("============== 어떻게 하시겠습니까? : ");

            string input = Console.ReadLine();

            if (input == "1")
            {
                player.Ult++;
                if (player.Ult > 5) player.Ult=5;
                Console.WriteLine("\n");
                monster.HP -= player.ATK;
                Console.WriteLine($"================== [ {player.Name} ]의 공격!\t {monster.Name}은/는 {player.ATK}의 피해를 입었다.\n");
                Thread.Sleep(400);
                player.HP -= monster.ATK;
                Console.WriteLine($"================== [ {monster.Name} ]의 공격!\t {player.Name}은/는 {monster.ATK}의 피해를 입었다.\n");
                if(player.HP <= 0)
                {
                    player.IsAlive = false;
                    run = true;
                }
                Thread.Sleep(400);

                if (monster.HP <= 0)
                {
                    Console.WriteLine($"[ {monster.Name} ]을/를 처치했다!");
                    player.EX += 40;
                    if(player.EX >= player.MEX)
                    {
                        player.EX -= player.MEX;
                        player = LevelUp(player);
                    }
                    player.STAGE++;
                    run = true;

                    Thread.Sleep(1500);
                }
                GameStop();
            }
            else if (input == "2")
            {
                if(player.Ult == 5)
                {
                    player.Ult = 0;
                    Console.WriteLine("\n");
                    Console.WriteLine($"================== [ {player.Name} ]가 궁극기를 사용했다!!!!!\t [ {monster.Name} ]은/는 즉사했다.\n");
                    Console.WriteLine($"[ {monster.Name} ]을/를 처치했다!");
                    player.EX += 40;
                    if (player.EX >= player.MEX)
                    {
                        player.EX -= player.MEX;
                        player = LevelUp(player);
                    }
                    player.STAGE++;
                    run = true;

                    Thread.Sleep(1500);
                }
                else
                {
                    Console.WriteLine("궁극기포인트가 부족합니다.");
                }
                GameStop();
            }
            else if (input == "3")
            {
                Console.WriteLine("도망갑니다.");
                Thread.Sleep(1000);
                run = true;

                GameStop();
            }

            return run;
        }

        static void Main(string[] args)
        {
            Player player;
            Jobs Choice = Jobs.None;

            Console.WriteLine("\n\n============== [ TextRPG ] ==============\n\n");
            GameStop();

            while (true) // 직업선택
            {
                Choice = ChoiceJob();
                if (Choice != Jobs.None)
                { 
                    break;
                }
            }
            
            SetPlayer(Choice, out player); // 플레이어 설정
            
            Console.Write("\n이름을 입력해주세요 : ");
            player.Name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\n모험을 시작합니다. . . .\n");
            GameStop();

            while (true) 
            {
                if(player.IsAlive == false)
                {
                    Console.Clear();
                    Console.WriteLine("플레이어가 사망했습니다.");
                    Thread.Sleep(2000);
                    GameStop();
                    break;
                }
                Monster monster; 
                SetMonster(out monster);
                while (true)
                {
                    if(Menu(ref player, ref monster) == true)
                    {
                        break;
                    }
                }
            }
        }
    }
}