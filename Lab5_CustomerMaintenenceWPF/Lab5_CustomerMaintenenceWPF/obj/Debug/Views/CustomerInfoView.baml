   M S B A M L   `   `   `  ����V  RLab5_CustomerMaintenenceWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Lab5_CustomerMaintenenceWPF.Views!Lab5_CustomerMaintenenceWPF.Views  5      8    2Lab5_CustomerMaintenenceWPF.Views.CustomerInfoView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:Lab5_CustomerMaintenenceWPF.Views     5      $	��350��5      $	��525��6   .��5	      �   � ColumnDefinitions  5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $
��Exit��66   $��1��6N   $��5��6^   $��140,15,21,10q�6k   ��6   �� *ExitClickCommand+.��6�   Exit5      �� 5   
   $��Delete��68   $��1��6R   $��5��6b   $��21,15,140,10q�6p   ��6   �� *DeleteClickCommand+.��6�   Delete5      �� 5   
   $��Modify��68   $��5��6R   $��138,15,22,10q�6`   ��6   �� *ModifyClickCommand+.��6w   Modify5       �� 5!   
   $	��Add��66   $��5��6M   $��21,15,139,10q�6[   ��6   �� *AddClickCommand+.��6r   Add5"      �� 5#   
   $��GetCustomer��6>   $��64,10,111,13q�6]   $��1��6s   ��6   �� *GetCustomerClickCommand+.��6�   Get Customer5$      �� 5&   
   $��Customer ID��6   $��10,10,83,17q�6'   $��27(�6<   $��Berlin Sans FB Bold)�6J   5'      �� 5(   
   -   5         ��Name$ GetCustomerButton��5(      $��180,12,0,13q�6]   ��6.   �� *CustomerIDNotify+ �� Mode$ TwoWay=�.��6r   5)      �� 5.      $
��Name��6   $��27(�6*   $��31,10,150,13q�68   $��1��6N   $��Berlin Sans FB Bold)�6[   5/      �� 50   
   $��138,10,43,10q�6a   $��2��6w   $��1��6�   ��6   �� *
NameNotify+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��6�   51      �� 53   
   $��Address��6   $��27(�6#   $��2��61   $��10,10,139,10q�6>   $��Berlin Sans FB Bold)�6T   54      �� 55   
    �� 
IsReadOnly . $��138,10,43,10q�6P   $��2��6f   $��2��6s   ��6   �� *AddressNotify+$ OneWay=�.��6�   56      �� 58   
   $
��City��6   $��27(�6    $��Berlin Sans FB Bold)�6.   $��33,10,162,13q�6O   $��3��6e   59      �� 5:   
    . $��2��6M   $��138,10,43,10q�6a   $��3��6w   ��6   �� *
CityNotify+$ OneWay=�.��6�   5;      �� 5=   
   $��State��6   $��27(�6!   $��Berlin Sans FB Bold)�6/   $��33,11,150,9q�6P   $��4��6e   5>      �� 5?   
    . $��113,11,35,9q�6O   $��4��6d   ��6   �� *StateNotify+$ OneWay=�.��6q   5@      �� 5B   
   $��Zip Code��6   $��27(�6$   $��Berlin Sans FB Bold)�62   $��1��6S   $��0,11,140,10q�6c   $��4��6x   5C      �� 5D   
    . $��1��6Q   $��127,10,31,10q�6a   $��4��6w   ��6   �� *ZipCodeNotify+$ OneWay=�.��6�   5E      5F      5G      