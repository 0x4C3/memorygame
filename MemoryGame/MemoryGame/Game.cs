using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace MemoryGame
{
    public class Game 
    {

        Dictionary<string, BlocksPair> dicBlocks = new Dictionary<string, BlocksPair>();
        Random rndm = new Random();

        public delegate void BlocksCreated(Block block);
        public event BlocksCreated BlockCreated;

        public delegate void GameOverEventHandler();
        public event GameOverEventHandler GameOver;

        public delegate void ScoreChangedEventHandler(int score);
        public event ScoreChangedEventHandler ScoreChanged;

        public int TotalClickedBlockCount { get; private set; }

        private int Score = 0;
        private readonly int FinishScore = 0;
        private readonly int BlockCount = 0;
        private readonly Difficulty Dif;

        public static Game Instance = null;
        public Game(Difficulty dif)
        {
            Instance = this;
            switch (dif)
            {
                case Difficulty.Beginner:
                    BlockCount = 15;
                    break;
                case Difficulty.Easy:
                    BlockCount = 20;
                    break;
                case Difficulty.Normal:
                    BlockCount = 30;
                    break;
                case Difficulty.Hard:
                    BlockCount = 48;
                    break;
                case Difficulty.VeryHard:
                    BlockCount = 98;
                    break;
            }
            FinishScore = BlockCount * 10;
        }
        public void CreateBlocks()
        {
            ResourceManager MyResourceClass = new ResourceManager(typeof(Properties.Resources));
            ResourceSet resourceSet = MyResourceClass.GetResourceSet(CultureInfo.CurrentUICulture, true, true);
            List<Bitmap> imagesList = new List<Bitmap>();
            foreach (DictionaryEntry entry in resourceSet)
            {
                imagesList.Add((Bitmap)entry.Value);
            }
            List<Block> blockList = new List<Block>();
            for (int i = 1; i < BlockCount + 1; i++)
            {      
                int chooseImage = rndm.Next(0, imagesList.Count);
                var b1 = new Block(i.ToString()) { Bmp = imagesList.Count != 0 && 
                    i % 3 == 0 ? imagesList[chooseImage] : null };
                var b2 = new Block(i.ToString()) { Bmp = imagesList.Count != 0 &&
                    i % 3 == 0 ? imagesList[chooseImage] : null };
                if (i % 3 == 0 && imagesList.Count > 0)
                {
                    imagesList.RemoveAt(chooseImage);
                }
                blockList.Add(b1);
                blockList.Add(b2);
                dicBlocks.Add(i.ToString(), new BlocksPair() { Block1 = b1, Block2 = b2 });

               
            }
            while (blockList.Count > 0)
            {
                int index = rndm.Next(0, blockList.Count);
                BlockCreated(blockList[index]);
                blockList.RemoveAt(index);
            }

        }
        public void BlockClicked()
        {
            TotalClickedBlockCount++;
        }

        public void Check(string key)
        {
            BlocksPair blockPairs = new BlocksPair();

            TotalClickedBlockCount--;
            if (dicBlocks.TryGetValue(key, out blockPairs))
            {
                if (!(blockPairs.Block1.IsSolved && blockPairs.Block2.IsSolved) && 
                    blockPairs.Block1.IsDisplayed && blockPairs.Block2.IsDisplayed)
                { 
                    Score += 10;
                    ScoreChanged(Score);
                    blockPairs.Block1.IsSolved = true;
                    blockPairs.Block2.IsSolved = true;
                    blockPairs.Block1.RefreshWithInvoke();
                    blockPairs.Block2.RefreshWithInvoke();
                    if (Score == FinishScore)
                        GameOver();
                }
                else if (blockPairs.Block1.IsSolved && blockPairs.Block2.IsSolved)
                {
                    return;
                }
                else 
                { 
                    blockPairs.Block1.IsDisplayed = false;
                    blockPairs.Block2.IsDisplayed = false;
                    blockPairs.Block1.RefreshWithInvoke();
                    blockPairs.Block2.RefreshWithInvoke();
                }
            }
        }
    }
}
