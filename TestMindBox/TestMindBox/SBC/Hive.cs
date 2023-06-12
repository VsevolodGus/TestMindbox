using System.Reflection;

namespace TestMindBox.SBC;
internal class Hive
{
    private readonly static Random random = new Random(0);

    private readonly FlowersData _flowersData;

    /// <summary>
    /// каждая пчела представляет потенциальное решение
    /// чем больше пчел в улье, тем лучше
    /// Однако с ростом популяции пчел производительность программы уменьшается.
    /// </summary>
    private readonly int _totalNumberBees;
    private readonly int _countScout;
    private readonly int _countActive;
    private readonly int _countInactive;

    /// <summary>
    /// Кол-во циклов, чтобы ограничить кол-во расчетов
    /// Ищем приближенное к идеалу решение, а не идеальное
    /// lim = (идеал)
    /// но с каждой итерацией lim(n -> беск)(дельта оптимизации / затраченные ресурсы)  = 0
    /// </summary>
    private readonly int _maxCountCycles;
    /// <summary>
    /// Может определяться другими условиями (допустим пыльцы на цветке кончилась)
    /// </summary>
    private readonly int _maxCountVisits;

    private readonly double _probabilityPersuasion = 0.90;
    private readonly double _probabilityMistake = 0.01;

    private readonly Bee[] _bees;
    private readonly int[] _indexesOfInactiveBees;

    private char[] _bestMemoryMatrix;
    private double _bestMeasureOfQuality;

    public Hive(int countInactive
        , int countActive
        , int numberScout
        , int maxCountVisits
        , int maxCountCycles
        , FlowersData flowersData)
    {
        _totalNumberBees = countActive + countInactive + numberScout;
        _countScout = numberScout;
        _countActive = countActive;
        _countInactive = countInactive;

        _maxCountVisits = maxCountVisits;
        _maxCountVisits = maxCountCycles;

        _flowersData = new FlowersData(flowersData.Flowers.Length);

        _bees = new Bee[_totalNumberBees];
        _bestMemoryMatrix = GenerateRandomMemoryMatrix();
        _bestMeasureOfQuality = MeasureOfQuality(_bestMemoryMatrix);

        _indexesOfInactiveBees = new int[_countInactive];

        for (var i = 0; i < _totalNumberBees; i++)
        {
            StatusBee statusBee;
            if (i < _countInactive)
            {
                statusBee = StatusBee.Active;
                _indexesOfInactiveBees[i] = i;
            }
            else if (i < _countScout + _countInactive)
                statusBee = StatusBee.Scout;
            else
                statusBee = StatusBee.Active;


            char[] randomMemoryMatrix = GenerateRandomMemoryMatrix();
            double mq = MeasureOfQuality(randomMemoryMatrix);
            int numberOfVisits = 0;
            _bees[i] = new Bee(statusBee, randomMemoryMatrix, mq, numberOfVisits);

            if (_bees[i].MeasureOfQuality < _bestMeasureOfQuality)
                CopyBestResult(_bees[i]);
        }
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
        int numberOfSymbolsToPrint = 10;
        int increment = _maxCountCycles / numberOfSymbolsToPrint;
        if (doProgressBar)
        {
            Console.WriteLine("\nEntering SBC Traveling Salesman Problem algorithm main processing loop\n");
            Console.WriteLine("Progress: |==========|");
            Console.Write("           ");
        }
            
        int cycle = 0;

        while (cycle < _maxCountCycles)
        {
            for (int i = 0; i < _totalNumberBees; ++i)
            {
                if (_bees[i].Status == StatusBee.Active)
                    ProcessActiveBee(i);
                else if (_bees[i].Status == StatusBee.Scout)
                    ProcessScoutBee(i);
                else if (_bees[i].Status == StatusBee.InActive)
                    ProcessInactiveBee(i);
            }
            ++cycle;

            if (doProgressBar && cycle % increment == 0)
                Console.Write("^");
        }

        if (doProgressBar) 
            Console.WriteLine("");
    }

    private void ProcessActiveBee(int i)
    {
        char[] neighbor = GenerateNeighborMemoryMatrix(_bees[i].MemoryMatrix);
        double neighborQuality = MeasureOfQuality(neighbor);
        double probability = random.NextDouble();
        bool memoryWasUpdated = false;
        bool numberOfVisitsOverLimit = false;

        
        if (neighborQuality < _bees[i].MeasureOfQuality) // better
        { 
            if (probability < _probabilityMistake) // mistake
            { 
                ++_bees[i].CountrOfVisits;
                if (_bees[i].CountrOfVisits > _maxCountVisits)
                    numberOfVisitsOverLimit = true;
            }
            else // No mistake
            { 
                Array.Copy(neighbor, _bees[i].MemoryMatrix, neighbor.Length);
                _bees[i].MeasureOfQuality = neighborQuality;
                _bees[i].CountrOfVisits = 0;
                memoryWasUpdated = true;
            }
        }
        else // Did not find better neighbor
        { 
            if (probability < _probabilityMistake) // Mistake
            { 
                Array.Copy(neighbor, _bees[i].MemoryMatrix, neighbor.Length);
                _bees[i].MeasureOfQuality = neighborQuality;
                _bees[i].CountrOfVisits = 0;
                memoryWasUpdated = true;
            }
            else // No mistake
            { 
                ++_bees[i].CountrOfVisits;
                if (_bees[i].CountrOfVisits > _maxCountVisits)
                    numberOfVisitsOverLimit = true;
            }
        }



        if (numberOfVisitsOverLimit)
        {
            _bees[i].Status = StatusBee.InActive;
            _bees[i].CountrOfVisits = 0;
            int x = random.Next(_countInactive);
            _bees[_indexesOfInactiveBees[x]].Status = StatusBee.Active;
            _indexesOfInactiveBees[x] = i;
        }
        else if (memoryWasUpdated)
        {
            if (_bees[i].MeasureOfQuality < _bestMeasureOfQuality)
                CopyBestResult(_bees[i]);

            DoWaggleDance(i);
        }
    }

    private void ProcessScoutBee(int i)
    {
        char[] randomFoodSource = GenerateRandomMemoryMatrix();
        double randomFoodSourceQuality = MeasureOfQuality(randomFoodSource);

        if (randomFoodSourceQuality >= _bees[i].MeasureOfQuality)
            return;

        Array.Copy(randomFoodSource, _bees[i].MemoryMatrix, randomFoodSource.Length);
        _bees[i].MeasureOfQuality = randomFoodSourceQuality;

        if (_bees[i].MeasureOfQuality >= _bestMeasureOfQuality)
            return;

        CopyBestResult(_bees[i]);

        DoWaggleDance(i);
    }

    private void DoWaggleDance(int i)
    {
        for (int ii = 0; ii < _countInactive; ++ii)
        {
            int indexInActiveBee = _indexesOfInactiveBees[ii];
            if (_bees[i].MeasureOfQuality >= _bees[indexInActiveBee].MeasureOfQuality)
                continue;

            double p = random.NextDouble();
            if (_probabilityPersuasion > p)
                continue;

            Array.Copy(_bees[i].MemoryMatrix, _bees[indexInActiveBee].MemoryMatrix, _bees[i].MemoryMatrix.Length);
            _bees[indexInActiveBee].MeasureOfQuality = _bees[i].MeasureOfQuality;
        }
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
            result += _flowersData.Distance(char1, char2);
        }

        return result;
    }

    private char[] GenerateRandomMemoryMatrix()
    {
        var countFlowers = _flowersData.Flowers.Length;
        var result = new char[countFlowers];
        Array.Copy(_flowersData.Flowers, result, countFlowers);

        for (var i = 0; i < countFlowers; i++)
        {
            var r = random.Next(1, countFlowers);
            Swap(ref result[r], ref result[i]);
        }

        return result;
    }


    private void CopyBestResult(Bee bee)
    {
        Array.Copy(bee.MemoryMatrix, _bestMemoryMatrix, bee.MemoryMatrix.Length);
        _bestMeasureOfQuality = bee.MeasureOfQuality;
    }



    private void ProcessInactiveBee(int i)
    {
        return;
    }

    private void Swap<T>(ref T value1, ref T value2)
    {
        (value2, value1) = (value1, value2);
    }
}
