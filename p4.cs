namespace ProblemSet1
{
    class P4
    {
        public static void Main(String[] args) {
            System.Console.WriteLine("Problem 4");
        }

        public static void solve() {
              
            int test =  int.Parse(Console.ReadLine());

            for(int t = 1; t <= test; t++ ) {
                int f = int.Parse(Console.ReadLine());
                String[] friends = new String[f];

                for(int i = 0; i < friends.Length; i++) {
                    friends[i] = Console.ReadLine();
                }

                


            }
        }
    }
}