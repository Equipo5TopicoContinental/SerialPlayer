using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialPlayer
{


    public interface IPlayer
    {
        void Play();
        void Pause();
        void Stop();
        void Skip();
        void Prev();

        event EventHandler<PlayerResponseEventArgs> Response;
    }
}
