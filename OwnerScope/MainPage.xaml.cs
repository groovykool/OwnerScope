using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace OwnerScope
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainPage : Page
  {
    public MainPage()
    {
      this.InitializeComponent();
      KA.ScopeOwner = Base;
      TB.Text = "The Gray Canvas has a Flyout Menu with KA...\n\n";
      TB.Text += $"OwnerScope is now set to Base Grid\n\n";
    }

    private void MMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
    {
      
      TB.Text += $"Rotate Menu Pressed Source:{e.OriginalSource}\n";
    }

    private void KeyboardAccelerator_Invoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
    {
      TB.Text += $"CTRL-R Pressed ScopeOwner:{args.KeyboardAccelerator.ScopeOwner}\n";
    }

    private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
    {
      if(TOG.IsOn)
      {
        KA.ScopeOwner = null;
        TB.Text = $"OwnerScope is now set to Global\n\n";
      }
      else
      {
        KA.ScopeOwner = Base;
        TB.Text = $"OwnerScope is now Base Grid\n\n";
      }
    }
  }
}
