   M S B A M L   `   `   `  ????N  JCryptocurrenciesWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:CryptocurrenciesWPF.ViewsCryptocurrenciesWPF.Views  5      ,    &CryptocurrenciesWPF.Views.TopCoinsView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:CryptocurrenciesWPF.Views     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5      .??5
      ? *  $Microsoft.Xaml.Behaviors.Interaction    Triggers  5   
   +  %Microsoft.Xaml.Behaviors.EventTrigger  5         	EventName$ Loaded??6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6(   ?? *RefreshCommand+5       ? RowDefinitions 5   
   ?? 5      $
??auto ?6   $??35??6*   ?? 5      $
??auto ?6   $??15??6*   ?? 5      $
??auto ?6   $??99??6*   .+?5   
   ?? $??Top 10 Coins??6   $??0??5      $??24(?5      $??25,2,0,0q?6"   $??Bottom=?64   ?? 5   
   $??Data from CoinGecko??6   $??1??5      $??14(?5      
???????$??25,2,0,0q?64   $??Bottom=?6F   ?? 5   
   $??2??6   $??25,25,25,25q?5        ? Cursor$
 Hand??5"       ?? SelectionMode$ Single=?5#      ??5!      ?? *Coins+ ?? SelectedIndex 5$      ?? *SelectedItemIndex+ ?? Mode$ OneWayToSource=?  5&        5'      $ SelectionChanged??6!   . 5(         6,   ?? *ShowCoinInfoCommand+5)      	 ?? View	 5,      ?? 5-      .P?5.      ?? $??#??6%   
 ?? Width$
 40??60    ?? CellTemplate 5/      ?? 50      .R?51   "   ??  ?? TextAlignment$ Right=?6,   ??6B   ?? *MarketCapRank+52      54      ?? 56      $
??Coin??6%   $	
 305??63    57      ?? 58      .R?59   "   ?? $ Center=?6,   ?? 5:   &   ?6*   ?? *Name+ ?? 5;   &   $? (??6*    ?? 5<   &   ?6*   ?? *Symbol+ ?? 5=   &   $?)??6*   5>   #   5?      5A      ?? 5C      $??Price??6%   $	
 200??64    5D      ?? 5E      .R?5F   "   ?? $ Right=?6,   ??6B   ?? *Price+5G      5I      ?? 5K      $??
Market Cap??6%   $	
 200??69    5L      ?? 5M      .R?5N   "   ?? ??6,   ?? *	MarketCap+5O      5Q      5R      5T      5U      5V      