namespace AdventOfCodeCSharp.Day05
{
    public class CargoService
    {
        public List<Stack<char>> Crates;

        public CargoService()
        {
            Crates = new List<Stack<char>>();
            for (int i = 0; i < 9; i++)
            {
                Crates.Add(new Stack<char>());
            }
        }

        public void Move(int oldStack, int newStack)
        {
            Crates[newStack-1].Push(Crates[oldStack-1].Pop());
        }

        public void MoveMany(int oldStack, int newStack, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Move(oldStack, newStack);
            }
        }

        public void MoveManyPart2(int oldStack, int newStack, int count)
        {
            var data = new char[count];
            for (int i = 0; i < count; i++)
            {
                data[i] = Crates[oldStack-1].Pop();
            }
            for (int i = 0; i < count; i++)
            {
                Crates[newStack-1].Push(data[count-(i+1)]);
            }
        }
    }
}