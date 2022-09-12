using System;

namespace PracticeDotNet
{
    internal class addnum
    {
        private Action<int, int> sum;

        public addnum(Action<int, int> sum)
        {
            this.sum = sum;
        }
    }
}