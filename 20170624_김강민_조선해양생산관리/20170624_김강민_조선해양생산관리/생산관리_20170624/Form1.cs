using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ILOG.Concert;
using ILOG.CPLEX;
namespace 생산관리_20170624
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] A = new int[,]
                {
                {1,1,1,1,0 },
                {1,1,0,1,1 },
                {0,1,1,1,1 }
                };

            double[] L = new double[] { 8, 5, 7, 8, 4 };

            double G = 10.7;

            double[] N_Max = new double[] { 2, 2, 2 };

            int nbOfWorkers = A.GetLength(0);
            int nbOfTasks = A.GetLength(1);

            Cplex cplex = new Cplex();

            INumVar[,] X = new INumVar[nbOfWorkers, nbOfTasks];  // C라는 2차원 인덱스가 0이면, 행의 개수을 받겠다
                                                                         // C라는 2차원 인덱스가 1이면 열의 개수를 받겠다.
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    X[i, j] = cplex.BoolVar();

            List<INumVar> D_negative = new List<INumVar>();
            for (int i = 0; i < nbOfWorkers; i++)
                D_negative.Add(cplex.NumVar(0, double.MaxValue));


            List<INumVar> D_positive = new List<INumVar>();
            for (int i = 0; i < nbOfWorkers; i++)
                D_positive.Add(cplex.NumVar(0, double.MaxValue));

            //목적함수
            ILinearNumExpr objectiveFunction = cplex.LinearNumExpr();
            for (int i = 0; i < nbOfWorkers; i++)
                objectiveFunction.AddTerm(1, D_negative[i]);

            for (int i = 0; i < nbOfWorkers; i++)
                objectiveFunction.AddTerm(1, D_positive[i]); // C[i, j], X[i, j] 두개를 곱해서 objectiveFunction 에 넣겠다.

            //과제
            for (int i = 0; i < nbOfWorkers; i++)
            {
                ILinearNumExpr constLeft1 = cplex.LinearNumExpr();
                for (int j = 0; j < nbOfTasks; j++)
                    constLeft1.AddTerm(L[j], X[i, j]);
                constLeft1.AddTerm(1, D_negative[i]);
                constLeft1.AddTerm(-1, D_positive[i]);
                cplex.AddEq(constLeft1, G);
            }


            for (int j = 0; j < nbOfTasks; j++)
            {
                ILinearNumExpr constLeft2 = cplex.LinearNumExpr();
                for (int i = 0; i < X.GetLength(0); i++)
                    constLeft2.AddTerm(1, X[i, j]);
                cplex.AddEq(constLeft2, 1);
            }

            for (int i = 0; i < nbOfWorkers; i++)
                for (int j = 0; j < nbOfTasks; j++)
                    cplex.AddLe(X[i, j], A[i, j]);

            for (int i = 0; i < nbOfWorkers; i++)
            {
                ILinearNumExpr constLeft4 = cplex.LinearNumExpr();
                for (int j = 0; j < nbOfTasks; j++)
                    constLeft4.AddTerm(1, X[i, j]);
                cplex.AddLe(constLeft4, N_Max[i]);
            }

            cplex.AddMinimize(objectiveFunction);
            cplex.Solve();

            string solution = "";
            double tolerance = cplex.GetParam(Cplex.Param.MIP.Tolerances.Integrality); //tolerance를 정의함
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    if (cplex.GetValue(X[i, j]) >= 1 - tolerance)
                        solution += "(" + (i + 1).ToString() + " ," + (j + 1).ToString() + ")";

            MessageBox.Show("목적함수 값은 =" + cplex.GetObjValue() + "\r\n" + "선택된 변수는 =" + solution);
        }
    }
}
