using System;

namespace xUnitTest.Interfaces
{
    public interface IViewEvent
    {
        event Action Loaded;
        void Render(string str);
    }
}
