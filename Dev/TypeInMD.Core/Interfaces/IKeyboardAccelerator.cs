using System;
using TypeInMD.Core.Models;
using Windows.System;

namespace TypeInMD.Core.Interfaces
{
    public interface IKeyboardAccelerator
    {
        IDisposable Register(ShortcutKey key, EventHandler<KeyEventArgs> handler);

        IDisposable RegisterGlobal(EventHandler<KeyEventArgs> handler);

        IObservable<KeyEventArgs> GetObservable();

        string GetShortcutKeyText(ShortcutKey key);

        string GetVirtualKeyNameText(VirtualKey key);
    }
}
