namespace LSP
{
    internal class Penguin : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException("Penguins cannot fly!!");
        }
        public override void Eat()
        {
            Console.WriteLine("The penguin is eating");
        }
    }
}
