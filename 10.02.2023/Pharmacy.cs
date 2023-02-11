using System;

namespace _10._02._2023
{
    internal class Pharmacy
    {
        public Medicine[] Medicinies = new Medicine[0];

        public void AddMedicine(Medicine medicinies)
        {
            Array.Resize(ref Medicinies, Medicinies.Length + 1);
            Medicinies[Medicinies.Length - 1] = medicinies;
        }
    }
}
