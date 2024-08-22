using UnityEngine;

public class MainWindow : AbstractWindow
{
   public override EWindowType WindowType => EWindowType.Main;

   private readonly MainWindowView _view;

   // TODO Check 
   public MainWindow(MainWindowView view) : base(view)
   {
      _view = view;
   }
}
