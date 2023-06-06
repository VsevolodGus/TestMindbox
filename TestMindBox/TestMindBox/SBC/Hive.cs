using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMindBox.SBC;
internal class Hive
{
    static Random random;

    public FlowersData flowersData;

    /// <summary>
    /// каждая пчела представляет потенциальное решение
    /// чем больше пчел в улье, тем лучше
    /// Однако с ростом популяции пчел производительность программы уменьшается.
    /// </summary>
    public readonly int totalNumberBees;
    public readonly int numberScout;
    public readonly int numberActive;
    public readonly int numberInactive;

    public readonly int maxNumberCycles;
    public readonly int maxNumberVisits;

    public readonly double probPersuasion = 0.90;
    public readonly double probMistake = 0.01;

    public Bee[] bees;
    public char[] bestMemoryMatrix;
    public double bestMeasureOfQuality;
    public int[] indexesOfInactiveBees;

    public Hive(int numberInactive,
  int numberActive, int numberScout, int maxNumberVisits,
  int maxNumberCycles, FlowersData floorsData)
    {

        random = new Random(0);

        this.totalNumberBees = numberActive + numberInactive + numberScout;
        this.numberScout = numberScout;
        this.numberActive = numberActive;
        this.numberInactive = numberInactive;

        this.maxNumberVisits = maxNumberVisits;
        this.maxNumberVisits = maxNumberCycles;

        this.flowersData = new FlowersData(floorsData.cities.Length);

        this.bees = new Bee[totalNumberBees];
        this.bestMemoryMatrix = GenerateRandomMemoryMatrix();
        this.bestMeasureOfQuality = MeasureOfQuality(this.bestMemoryMatrix);

        this.indexesOfInactiveBees = new int[this.numberInactive];

        for (var i = 0; i < this.totalNumberBees; i++)
        {
            StatusBee statusBee;
            if (i < this.numberInactive)
            {
                statusBee = StatusBee.Active;
                indexesOfInactiveBees[i] = i;
            }
            else if (i < numberScout + numberInactive)
                statusBee = StatusBee.Scout;
            else
                statusBee = StatusBee.Active;


            char[] randomMemoryMatrix = GenerateRandomMemoryMatrix();
            double mq = MeasureOfQuality(randomMemoryMatrix);
            int numberOfVisits = 0;
            bees[i] = new Bee(statusBee, randomMemoryMatrix, mq, numberOfVisits);

            if (bees[i].measureOfQuality < bestMeasureOfQuality)
            {
                Array.Copy(bees[i].memoryMatrix, this.bestMemoryMatrix,
                  bees[i].memoryMatrix.Length);
            }

            this.bestMeasureOfQuality = bees[i].measureOfQuality;


        }
    }

    public char[] GenerateRandomMemoryMatrix()
    {
        var countFlowers = this.flowersData.cities.Length;
        var result = new char[countFlowers];
        Array.Copy(flowersData.cities, result, countFlowers);

        for (var i = 0; i < countFlowers; i++)
        {
            var r = random.Next(1, countFlowers);
            Swap(ref result[r], ref result[i]);
        }

        return result;
    }

    private void Swap<T>(ref T value1, ref T value2)
    {
        (value2, value1) = (value1, value2);
    }

    /// <summary>
    /// По сути это метод вычисления веса варианта
    /// По всем точка выбранного маршрута в графе
    /// Наиболее тяжелый метод в алгоритме SBC, обратить внимание на это
    /// </summary>
    /// <param name="memoryMatrix">последовательность маршрута</param>
    /// <returns>вес маршрута</returns>
    public double MeasureOfQuality(char[] memoryMatrix)
    {
        var result = 0.0;

        for (var i = 0; i < memoryMatrix.Length - 1; i++)
        {
            var char1 = memoryMatrix[i];
            var char2 = memoryMatrix[i + 1];
            result += flowersData.Distance(char1, char2);
        }

        return result;
    }

    public char[] GenerateNeighborMemoryMatrix(char[] memoryMatrix)
    {
        var result = new char[memoryMatrix.Length];
        Array.Copy(result, memoryMatrix, result.Length);

        int randomIndex = random.Next(0, result.Length-1);
        int adjIndex;
        if(randomIndex == result.Length-1) 
            adjIndex = 0;
        else
            adjIndex = randomIndex + 1;

        Swap(ref result[randomIndex], ref result[adjIndex]);

        return result;
    }

    public void Solve(bool doProgressBar)
    {
        bool pb = doProgressBar;
        int numberOfSymbolsToPrint = 10;
        int increment = this.maxNumberCycles / numberOfSymbolsToPrint;
        if (pb)
        {
            Console.WriteLine("\nEntering SBC Traveling Salesman Problem algorithm main processing loop\n");
            Console.WriteLine("Progress: |==========|");
            Console.Write("           ");
        }
            
        int cycle = 0;

        while (cycle < this.maxNumberCycles)
        {
            for (int i = 0; i < totalNumberBees; ++i)
            {
                if (this.bees[i].status == StatusBee.Active)
                    ProcessActiveBee(i);
                else if (this.bees[i].status == StatusBee.Scout)
                    ProcessScoutBee(i);
                else if (this.bees[i].status == StatusBee.InActive)
                    ProcessInactiveBee(i);
            }
            ++cycle;

            if (pb && cycle % increment == 0)
                Console.Write("^");
        }

        if (pb) 
            Console.WriteLine("");
    }

    private void ProcessActiveBee(int i)
    {
        char[] neighbor = GenerateNeighborMemoryMatrix(bees[i].memoryMatrix);
        double neighborQuality = MeasureOfQuality(neighbor);
        double prob = random.NextDouble();
        bool memoryWasUpdated = false;
        bool numberOfVisitsOverLimit = false;

        
        if (neighborQuality < bees[i].measureOfQuality) // better
        { 
            if (prob < probMistake) // mistake
            { 
                ++bees[i].numberOfVisits;
                if (bees[i].numberOfVisits > maxNumberVisits)
                    numberOfVisitsOverLimit = true;
            }
            else // No mistake
            { 
                Array.Copy(neighbor, bees[i].memoryMatrix, neighbor.Length);
                bees[i].measureOfQuality = neighborQuality;
                bees[i].numberOfVisits = 0;
                memoryWasUpdated = true;
            }
        }
        else // Did not find better neighbor
        { 
            if (prob < probMistake) // Mistake
            { 
                Array.Copy(neighbor, bees[i].memoryMatrix, neighbor.Length);
                bees[i].measureOfQuality = neighborQuality;
                bees[i].numberOfVisits = 0;
                memoryWasUpdated = true;
            }
            else // No mistake
            { 
                ++bees[i].numberOfVisits;
                if (bees[i].numberOfVisits > maxNumberVisits)
                    numberOfVisitsOverLimit = true;
            }
        }

        if (numberOfVisitsOverLimit)
        {
            bees[i].status = StatusBee.InActive;
            bees[i].numberOfVisits = 0;
            int x = random.Next(numberInactive);
            bees[indexesOfInactiveBees[x]].status = StatusBee.Active;
            indexesOfInactiveBees[x] = i;
        }
        else if (memoryWasUpdated)
        {
            if (bees[i].measureOfQuality < this.bestMeasureOfQuality)
            {
                Array.Copy(bees[i].memoryMatrix, this.bestMemoryMatrix,
                  bees[i].memoryMatrix.Length);
                this.bestMeasureOfQuality = bees[i].measureOfQuality;
            }
            DoWaggleDance(i);
        }
        else
            return;   
    }

    private void ProcessScoutBee(int i)
    {
        char[] randomFoodSource = GenerateRandomMemoryMatrix();
        double randomFoodSourceQuality = MeasureOfQuality(randomFoodSource);

        if (randomFoodSourceQuality >= bees[i].measureOfQuality)
            return;

        Array.Copy(randomFoodSource, bees[i].memoryMatrix, randomFoodSource.Length);
        bees[i].measureOfQuality = randomFoodSourceQuality;

        if (bees[i].measureOfQuality >= bestMeasureOfQuality)
            return;

        Array.Copy(bees[i].memoryMatrix, this.bestMemoryMatrix, bees[i].memoryMatrix.Length);
        this.bestMeasureOfQuality = bees[i].measureOfQuality;

        DoWaggleDance(i);
    }

    private void DoWaggleDance(int i)
    {
        for (int ii = 0; ii < numberInactive; ++ii)
        {
            int indexInActiveBee = indexesOfInactiveBees[ii];
            if (bees[i].measureOfQuality >= bees[indexInActiveBee].measureOfQuality)
                continue;

            double p = random.NextDouble();
            if (this.probPersuasion > p)
                continue;

            Array.Copy(bees[i].memoryMatrix, bees[indexInActiveBee].memoryMatrix, bees[i].memoryMatrix.Length);
            bees[indexInActiveBee].measureOfQuality = bees[i].measureOfQuality;
        }
    }

    private void ProcessInactiveBee(int i)
    {
        return;
    }
}
