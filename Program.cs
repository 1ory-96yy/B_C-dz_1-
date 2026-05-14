using System;
using ConsoleApp2.Services;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var blockchainService = new Services.BlockChaineService();
            var displayService = new Services.BlockChainDisplayService();

            blockchainService.AddBlock("First Block" , "Alice");
            blockchainService.AddBlock("Second Block", "Bob");
            blockchainService.AddBlock("Third Block", "Charlie");

            displayService.printChain(blockchainService.chain);
            displayService.printChainValidity(blockchainService.IsChainValid());

            blockchainService.chain[1].data = "Tampered Data";
            displayService.printChain(blockchainService.chain);
            displayService.printChainValidity(blockchainService.IsChainValid());
        }
    }
}
