namespace ConsoleApp2.Services
{
    public class BlockChainDisplayService
    {
        public void printChain(List<Models.Block> chain)
        {
            foreach (var block in chain)
            {
                Console.WriteLine($"Auth: {block.auth}");
                Console.WriteLine($"Index: {block.index}");
                Console.WriteLine($"Timestamp: {block.timestamp}");
                Console.WriteLine($"Data: {block.data}");
                Console.WriteLine($"Hash: {block.hash}");
                Console.WriteLine($"Previous Hash: {block.previousHash}");
                Console.WriteLine(new string('-', 20));
            }
        }

        public void printChainValidity(bool isValid)
        {
            if (isValid)
            {
                Console.WriteLine("");
                Console.WriteLine("The blockchain is valid.");
                Console.WriteLine("");

                Console.WriteLine(new string('-', 20));
            }
            else
            {
                Console.WriteLine("");

                Console.WriteLine("The blockchain is invalid.");
                Console.WriteLine("");

                Console.WriteLine(new string('-', 20));
            }
        }
    }
}
