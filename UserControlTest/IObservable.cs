using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControlTest
{
    interface IObservable
    {
        void Add(IObserver observer); // オブサーバーの追加
        void Notify(); // 全オブザーバーに更新を通知
    }
}
