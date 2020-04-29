﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemAnalyze5
{
    class MetricsCalculation
    {
        private List<List<int>> matrix;
        int tops;
        bool orient;

        public MetricsCalculation(List<List<int>> _matrix, int _topsQuan, bool _orient)
        {
            this.matrix = _matrix;
            this.tops = _topsQuan;
            this.orient = _orient;
        }

        public double getRValue()
        {
            int matrixElementsSum = matrix.Sum(x => x.Sum(y => y));
            return 1 / (2 * ((double)tops - 1)) * matrixElementsSum - 1;
        }

        private static List<List<int>> transformGraphToUnoriented(List<List<int>> _AMatrix, int _range)
        {
            for (int i=0; i!= _range; ++i)
            {
                for (int j=i+1; j!= _range; ++j)
                {
                    _AMatrix[i][j] = _AMatrix[j][i] = Convert.ToInt32(Convert.ToBoolean(_AMatrix[i][j]) || Convert.ToBoolean(_AMatrix[j][i]));
                }
            }
            return _AMatrix;
        }

        public double getE2Value()
        {
            List<List<int>> unorientedMatrix = null;
            if (this.orient)
                unorientedMatrix = transformGraphToUnoriented(this.matrix, this.tops);
            else
                unorientedMatrix = this.matrix;
            double mValue = 0.5*unorientedMatrix.Sum(x => x.Count(y => y == 1));
            double gMean = 2 * mValue / tops;
            double E2Value = 0;
            for(int i=0; i!= tops; ++i)
            {
                E2Value += Math.Pow((unorientedMatrix[i].Count(x => x == 1) - gMean), 2);
            }
            return E2Value;
        }
    }
}