using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMindBox.SBC;
internal class Hive
{
    static Random random;

    public FlowersData floorsData;

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

        this.floorsData = new FlowersData(floorsData.cities.Length);
        this.bees = new Bee[totalNumberBees];
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
        return null;
    }

    public double MeasureOfQuality(char[] chars)
    {
        return default;
    }
}
