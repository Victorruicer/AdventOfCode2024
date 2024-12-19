namespace AdventOfCode2024
{
    public class Day1
    {
        public void day1()
        {
            try
            {
                int distance = 0;
                int similarity = 0;

                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Day1", "input.txt");

                List<string> leftList = new List<string>();
                List<string> rightList = new List<string>();

                foreach (var line in File.ReadLines(filePath))
                {
                    //Divide the line in two by the blank space
                    string[] lineArray = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    //There should be only two elements in the array
                    if (lineArray.Length != 2)
                    {
                        throw new Exception("The line should have only two elements");
                    }

                    leftList.Add(lineArray[0]);
                    rightList.Add(lineArray[1]);
                }

                //-------- CALCULATE DISTANCE -------- (Part1)
                //Order the lists
                leftList = leftList.OrderBy(x => x).ToList();
                rightList = rightList.OrderBy(x => x).ToList();

                for (int i = 0; i < leftList.Count; i++)
                {
                    int leftNum = int.Parse(leftList[i]);
                    int rightNum = int.Parse(rightList[i]);

                    distance += Math.Abs(leftNum - rightNum);
                }

                Console.WriteLine("Distance: " + distance);

                //-------- CALCULATE SIMILARITY -------- (Part2)
                for (int i = 0; i < leftList.Count; i++)
                {
                    string leftNumber = leftList[i];
                    int countOfSimilarity = 0;

                    foreach (string rightNumber in rightList)
                    {
                        if (leftNumber == rightNumber) countOfSimilarity++;
                    }

                    int numberSimilarity = int.Parse(leftNumber) * countOfSimilarity;
                    similarity += numberSimilarity;
                }

                Console.WriteLine("Similarity: " + similarity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado en el código: '" + ex.Message + "'");
            }
        }
    }
}