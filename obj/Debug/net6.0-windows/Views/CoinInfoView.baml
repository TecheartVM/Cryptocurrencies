   M S B A M L   `   `   `  ????N  JCryptocurrenciesWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:CryptocurrenciesWPF.ViewModels.Coins$CryptocurrenciesWPF.ViewModels.Coins  5      E'clr-namespace:CryptocurrenciesWPF.ViewsCryptocurrenciesWPF.Views  5      ,    &CryptocurrenciesWPF.Views.CoinInfoView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Bvms2clr-namespace:CryptocurrenciesWPF.ViewModels.Coins     5      9views'clr-namespace:CryptocurrenciesWPF.Views     5      .??5
      ?   ? 	Resources  5   
    ?? DataType?   9CryptocurrenciesWPF.ViewModels.Coins.CoinTickersViewModel/   )CryptocurrenciesWPF.Views.CoinTickersView??%G   (??       5      *, +)?? 6   "  6   .R?5        5      5       ? RowDefinitions 5   
   ?? 5      $
??auto ?6   $??35??6*   ?? 5      $
??auto ?6   $??30??6*   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   $	??300??6*   .+?5   
   ?? -   5         ??Name$ BackBtn??5      $??0??5      $
??🡸??5      $
??Left=?5      $??Bottom=?6,   $??10,0,0,0q?5      $??35??5      $??35??6    ? Cursor$
 Hand??5       ??5   %   ?? *GoBackCommand+5       ?? 5"   
   -   5        $ HomeBtn??5#      $??0??5"      $
??Home??5$      $??Right=?5%      $??Bottom=?6-   $??0,0,10,0q?5&      $??20??5'      $??80??6   $
 Hand??5(      ??5$       ?? *GoHomeCommand+5(      ?? 5*   
   $??0??6   $??
80,0,175,0q?6!   $??Bottom=?65   $??20(?6P   ?? 5+      $??34(?6=   ?6   ?? *Localization+ ?? Mode$ OneWay=?6=    ?? 5,      $? (??6   
???????6    ?? 5-      
????????6   ?? *Symbol+$ OneWay=?67    ?? 5.      $?)??6   
???????6   5/      ?? 51   
   $??1??6   $??80,5,5,5q?6!   $??Center=?63   $??20(?6N   ?? 52      ?6   ?? *Price+$ OneWay=? ?? StringFormat$ {0:C0}?? ?? 53      $? ??6    ?? 54      ?6   ?? *PriceChange+$ OneWay=???6<   ?? *PriceChangeColor+$ OneWay=? ?? 55      $?%??6   ??6   ?? *PriceChangeColor+$ OneWay=?56      ?? 58   
   $??2??6   $??80,0,5,5q?6!   $??Center=?63   ?? 59      $?Market Cap    ??6    ?? 5:      ?6   ?? *	MarketCap+$ OneWay=?$ {0:C0}??5;      ?? 5=   
   $??3??6   $??80,0,5,5q?6!   $??Center=?63   ?? 5>      $?
Volume    ??6    ?? 5?      ?6   ?? *Volume+$ OneWay=?$ {0:C0}??5@      ?? 5B   
   $??4??6   $??80,0,5,5q?6!   $??Center=?63   ?? 5C      $?Genesis date    ??6    ?? 5D      ?6   ?? *GenesisDate+$ OneWay=?$ d??5E      ?? 5G   
   $??5??6   ??6&   ?? *TickersViewModel+5H      5I      