using System;

namespace ParkingLot
{
    class ParkingLot
    {
        private int numCarSpots;
        private int numMotorcycleSpots;
        private int numVanSpots;
        private bool[] carSpots;
        private bool[] motorcycleSpots;
        private bool[] vanSpots;

        public ParkingLot(int numCarSpots, int numMotorcycleSpots, int numVanSpots)
        {
            this.numCarSpots = numCarSpots;
            this.numMotorcycleSpots = numMotorcycleSpots;
            this.numVanSpots = numVanSpots;
            carSpots = new bool[numCarSpots];
            motorcycleSpots = new bool[numMotorcycleSpots];
            vanSpots = new bool[numVanSpots];
        }

        public int GetNumSpotsRemaining()
        {
            int numSpotsRemaining = 0;
            for (int i = 0; i < carSpots.Length; i++)
            {
                if (!carSpots[i])
                {
                    numSpotsRemaining++;
                }
            }
            for (int i = 0; i < motorcycleSpots.Length; i++)
            {
                if (!motorcycleSpots[i])
                {
                    numSpotsRemaining++;
                }
            }
            for (int i = 0; i < vanSpots.Length; i++)
            {
                if (!vanSpots[i])
                {
                    numSpotsRemaining++;
                }
            }
            return numSpotsRemaining;
        }

        public int GetTotalNumSpots()
        {
            return numCarSpots + numMotorcycleSpots + numVanSpots;
        }

        public bool IsFull()
        {
            return GetNumSpotsRemaining() == 0;
        }

        public bool IsEmpty()
        {
            return GetNumSpotsRemaining() == GetTotalNumSpots();
        }

        public bool AreAllMotorcycleSpotsTaken()
        {
            for (int i = 0; i < motorcycleSpots.Length; i++)
            {
                if (!motorcycleSpots[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int GetNumVanSpotsTaken()
        {
            int numVanSpotsTaken = 0;
            for (int i = 0; i < vanSpots.Length; i++)
            {
                if (vanSpots[i])
                {
                    numVanSpotsTaken++;
                }
            }
            return numVanSpotsTaken;
        }

        public bool ParkCar()
        {
            for (int i = 0; i < carSpots.Length; i++)
            {
                if (!carSpots[i])
                {
                    carSpots[i] = true;
                    return true;
                }
            }
            return false;
        }

        public bool ParkMotorcycle()
        {
            for (int i = 0; i < motorcycleSpots.Length; i++)
            {
                if (!motorcycleSpots[i])
                {
                    motorcycleSpots[i] = true;
                    return true;
                }
            }
            return false;
        }

        public bool ParkVan()
        {
            for (int i = 0; i < vanSpots.Length; i++)
            {
                if (!vanSpots[i] && i + 1 < vanSpots.Length && !vanSpots[i+1])
                {
                    vanSpots[i] = true;
                    vanSpots[i+1] = true;
                    return true;
                }
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ParkingLot parkingLot = new ParkingLot(numCarSpots: 10, numMotorcycleSpots: 20, numVanSpots: 5);

            Console.WriteLine($"Total number of spots in the parking lot: {parkingLot.GetTotalNumSpots()}");
            Console.WriteLine($"Number of spots remaining in the parking lot: {parkingLot.GetNumSpotsRemaining()}");

            // Park some cars, motorcycles, and vans
            parkingLot.ParkCar();
            parkingLot.ParkCar();
            parkingLot.ParkMotorcycle();
            parkingLot.ParkVan();
            parkingLot.ParkVan();
            parkingLot.ParkVan();

            Console.WriteLine($"Number of spots remaining in the parking lot: {parkingLot.GetNumSpotsRemaining()}");

            if (parkingLot.IsFull())
            {
                Console.WriteLine("The parking lot is full.");
            }

            if (parkingLot.IsEmpty())
            {
                Console.WriteLine("The parking lot is empty.");
            }

            if (parkingLot.AreAllMotorcycleSpotsTaken())
            {
                Console.WriteLine("All motorcycle spots are taken.");
            }

            Console.WriteLine($"Number of spots taken up by vans: {parkingLot.GetNumVanSpotsTaken()}");
        }
    }
}
