using System;
using System.Collections.Generic;

namespace BingoAtividadeAvaliativa.Entities
{
    public class BingoBusiness
    {
        private Random r;

        public BingoBusiness()
        {
            r = new Random();
        }

        private int GenerateNumber(int min, int max)
        { 
            return r.Next(min, max);
        }

        public List<Row> GenerateBingoCard(int size)
        {
            List<Row> rows = new List<Row>();
            int bingoCardSize = size;

            // Listas auxiliares para verificação de duplicidade de cada letra
            var auxb = new List<int>();
            var auxi = new List<int>();
            var auxn = new List<int>();
            var auxg = new List<int>();
            var auxo = new List<int>();

            for (int i = 0; i < bingoCardSize; i++)
            {
                var row = new Row();
                for (int j = 0; j < bingoCardSize; j++)
                {
                    switch (j)
                    {
                        case 0:
                            var b = GenerateNumber(1, 15);
                            if (i == 0)
                            {
                                auxb.Add(b);
                            }
                            else
                            {
                                while (auxb.Contains(b))
                                {
                                    b = GenerateNumber(1, 15);
                                }
                                auxb.Add(b);
                            }
                            row.B = b;
                            break;
                        case 1:
                            var ip = GenerateNumber(16, 30);
                            if (i == 0)
                            {
                                auxi.Add(ip);
                            }
                            else
                            {
                                while (auxi.Contains(ip))
                                {
                                    ip = GenerateNumber(16, 30);
                                }
                                auxi.Add(ip);
                            }
                            row.I = ip;
                            break;
                        case 2:
                            var n = GenerateNumber(31, 45);
                            if (i == 0)
                            {
                                auxn.Add(n);
                            }
                            else
                            {
                                while (auxn.Contains(n))
                                {
                                    n = GenerateNumber(31, 45);
                                }
                                auxn.Add(n);
                            }
                            row.N = n;
                            break;
                        case 3:
                            var g = GenerateNumber(46, 60);
                            if (i == 0)
                            {
                                auxg.Add(g);
                            }
                            else
                            {
                                while (auxg.Contains(g))
                                {
                                    g = GenerateNumber(46, 60);
                                }
                                auxg.Add(g);
                            }
                            row.G = g;
                            break;
                        case 4:
                            var o = GenerateNumber(61, 75);
                            if (i == 0)
                            {
                                auxo.Add(o);
                            }
                            else
                            {
                                while (auxo.Contains(o))
                                {
                                    o = GenerateNumber(61, 75);
                                }
                                auxo.Add(o);
                            }
                            row.O = o;
                            break;
                    }
                }
                rows.Add(row);
            }
            return rows;
        }
    }
}