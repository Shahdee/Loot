using System.Collections.Generic;

public interface IWindowStorage
{
    Dictionary<EWindowType, IWindow> AllWindows {get;}
    IWindow Get(EWindowType windowType);
}
