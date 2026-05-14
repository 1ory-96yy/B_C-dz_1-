using ConsoleApp2.Models;

namespace ConsoleApp2.Services
{
    public class BlockChaineService
    {
        public List<Block> chain { get; set; }
        private readonly HashingService hashingService;



        public BlockChaineService()
        {
            this.chain = new List<Block>();
            this.hashingService = new HashingService();
            this.CreateGenesisBlock();
        }

        private void CreateGenesisBlock()
        {
            var genesisBlock = new Block(0, "0", "", "Genesis");
            genesisBlock.hash = this.hashingService.ComputeHash(genesisBlock);
            this.chain.Add(genesisBlock);
        }

        public void AddBlock(string data, string auth)
        {
            var previousBlock = this.chain.Last();
            var newBlock = new Block(previousBlock.index + 1, data, previousBlock.hash, auth);
            newBlock.hash = this.hashingService.ComputeHash(newBlock);
            this.chain.Add(newBlock);
        }

        public bool IsChainValid()
        {
            for (int i = 1; i < this.chain.Count; i++)
            {
                var currentBlock = this.chain[i];
                var previousBlock = this.chain[i - 1];
                if (currentBlock.hash != this.hashingService.ComputeHash(currentBlock))
                    return false;
                if (currentBlock.previousHash != previousBlock.hash)
                    return false;
            }
            return true;
        }
    }
}
