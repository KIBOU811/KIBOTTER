using System;
using System.Collections.Generic;

namespace KIBOTTER
{
    class Prime
    {
        /// <summary>
        /// 素数判定
        /// </summary>
        /// <param name="n">判定したい自然数</param>
        /// <returns>素数ならtrue でないならfalse</returns>
        private bool IsPrime(int n)
        {
            if (n == 2 || n == 3)
                return true;

            if (n % 2 == 0 || n < 2)
                return false;

            int sqrt = (int)Math.Sqrt(n);

            for (int i = 3; i <= sqrt; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 素数判定
        /// </summary>
        /// <param name="n">判定したい自然数</param>
        /// <returns>素数ならtrue でないならfalse</returns>
        private bool IsPrime(long n)
        {
            if (n == 2 || n == 3)
                return true;

            if (n % 2 == 0 || n < 2)
                return false;

            long sqrt = (long)Math.Sqrt(n);

            for (long i = 3; i <= sqrt; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 素数列取得
        /// </summary>
        /// <param name="n">までの素数を列挙</param>
        /// <returns>nまでの列挙された素数リスト 失敗で空のリスト</returns>
        public List<int> GetPrimeList(int n)
        {
            List<int> primeList = new List<int>();

            if (n < 2)
                return primeList;

            primeList.Add(2);

            for (int i = 3; i <= n; i += 2)
            {
                if (IsPrime(i))
                    primeList.Add(i);
            }

            return primeList;
        }

        /// <summary>
        /// 素数列取得
        /// </summary>
        /// <param name="n">までの素数を列挙</param>
        /// <returns>nまでの列挙された素数リスト 失敗で空のリスト</returns>
        public List<long> GetPrimeList(long n)
        {
            List<long> primeList = new List<long>();

            if (n < 2)
                return primeList;

            primeList.Add(2);

            for (long i = 3; i <= n; i += 2)
            {
                if (IsPrime(i))
                    primeList.Add(i);
            }

            return primeList;
        }
    }
}
