using System;

namespace WSUniversalLib
{
    public class Calculation
    {
        private const int ToPercentFactor = 100;

        public int GetQuantityForProduct(int productType,
                                         int materialType,
                                         int count,
                                         float width,
                                         float length)
        {
            if (count <= 0)
            {
                return -1;
            }
            if (width <= 0)
            {
                return -1;
            }
            if (length <= 0)
            {
                return -1;
            }
            float area = width * length;
            double productTypeFactor;
            double materialDefectPercent;
            switch (productType)
            {
                case 1:
                    productTypeFactor = 1.1;
                    break;
                case 2:
                    productTypeFactor = 2.5;
                    break;
                case 3:
                    productTypeFactor = 8.43;
                    break;
                default:
                    return -1;
            }
            switch (materialType)
            {
                case 1:
                    materialDefectPercent = 0.3 / ToPercentFactor;
                    break;
                case 2:
                    materialDefectPercent = 0.12 / ToPercentFactor;
                    break;
                default:
                    return -1;
            }
            double rawCountOfQualityRawMaterial = area * productTypeFactor * count;
            double howMuchIsNeedToAdd = 1 - materialDefectPercent;
            double countOfQualityRawMaterial = rawCountOfQualityRawMaterial / howMuchIsNeedToAdd;

            if (countOfQualityRawMaterial > int.MaxValue)
            {
                return -1;
            }

            return (int)Math.Ceiling(countOfQualityRawMaterial);
        }
    }
}
