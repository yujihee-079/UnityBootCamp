namespace _20250826_2
{
    //Nullable - null이 able 가능한
    // 게임쪽은 상대적으로 덜 사용함
    // 다만 DB 같은거 하면 사용함
    class Monster
    {
        public int Id;
        public Monster(int id)
        { this.Id = id; }
        public Monster MatchId(int id)
        { 
            if(this.Id == id)
                return this;
            return null;
        }
        public int Search(int id)
        { 
            return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;

            //int b = a.Value;
            // Console.WriteLine(b);
            int c = a ?? 5;
            Console.WriteLine(c);

            if (a.HasValue == true)
            {
                int b = a.Value;

                Console.WriteLine(b);
            }
            else
            {
                int b = 4;
                Console.WriteLine(b);
            }

            Monster monster = new Monster(20);
            Monster found = monster.MatchId(11);
        }
    }
}
