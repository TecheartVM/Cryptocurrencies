   M S B A M L   `   `   `  ????N  JCryptocurrenciesWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CryptocurrenciesWPF.ViewsCryptocurrenciesWPF.Views  5      /    )CryptocurrenciesWPF.Views.CoinTickersView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:CryptocurrenciesWPF.Views     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5      .??5
      ? *  $Microsoft.Xaml.Behaviors.Interaction    Triggers  5   
   +  %Microsoft.Xaml.Behaviors.EventTrigger  5         	EventName$ Loaded??6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6(   ?? *RefreshPageCommand+5       ? RowDefinitions 5   
   ?? 5      $
??auto ?6   $??25??6*   ?? 5      $
??Auto ?6   $	??200??6*   $	??200??6:   ?? 5      $
??auto ?6   $??35??6*   .+?5   
   ?? $??Market trades??6   $??0??5      $??20(?5      $??80,2,0,0q?6"   $??Bottom=?64   ?? 5   
   $??1??6   $??	80,5,80,5q?5      $	??190??5       ? Cursor$
 Hand??5       ?? SelectionMode$ Single=?5       $??Visible=?5"      $??Hidden=?5#      $??False??5$      ??5      ?? *	Tickers+ ?? SelectedIndex 5!      ?? *SelectedItemIndex+  5&        5'      $ SelectionChanged??6!   . 5(         6,   ?? *FollowHyperlinkCommand+5)       ?? View 5,      ?? 5-      .P?5.      ?? $??Market??6%   	 ?? Width$		 217??65   
 ?? CellTemplate
 5/      ?? 50      .R?51   "   ??  ?? TextAlignment$
 Left=?6,    ?? Padding$ 40,0,0,0q?6A   ?? 52   .   $	?⦿??62   ??6B   ?? *
TrustColor+ ?? Mode$ OneWay=? ?? 53   .   ?62   ?? *
MarketName+$ OneWay=? ?? 54   .   $? (??62    ?? 55   .   ?62   ?? *
MarketId+$ OneWay=? ?? 56   .   $?)??62   57   #   58      5:      ?? 5<      $
??Deal??6%   $		 200??63   
 5=      ?? 5>      .R?5?   "   ?? $??Center=?6,   ?? 5@   &   ?6*   ?? *
BaseCoin+$ OneWay=? ?? 5A   &   $?/??6*    ?? 5B   &   ?6*   ?? *
TargetCoin+$ OneWay=?5C   #   5D      5F      ?? 5H      $??Price??6%   $		 200??64   
 5I      ?? 5J      .R?5K   "   ?? $
??Left=?6,   ??5L   ,   ?? *Price+$ OneWay=? ?? StringFormat$ {0:C0}??5M      5O      5P      5R      ?? 5T   
   $??2??6   $??Previous??5U      $	??100??5V      $??20??5W      $??80,0,0,0q?5X      $
??Left=?5Y      $	??Top=?5Z      ??5[      ?? *PreviousPageCommand+{?5\      ?? *HasPreviousPage+$ OneWay=??? 5^   
   $??2??6   $??Center=?5_      $??14(?5a      ??5`      ?? *Page+$ OneWay=?5c      ?? 5e   
   $??2??6   $
??Next??5f      $	??100??5g      $??20??5h      $??0,0,80,0q?5i      $??Right=?5j      $	??Top=?5k      ??5l      ?? *NextPageCommand+{?5m      ?? *HasNextPage+$ OneWay=?5n      5o      