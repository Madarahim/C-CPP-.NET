   M S B A M L   `   `   `  ����V  RLab5_CustomerMaintenenceWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:Lab5_CustomerMaintenenceWPF.Views!Lab5_CustomerMaintenenceWPF.Views  5   	   U/clr-namespace:Lab5_CustomerMaintenenceWPF.Views!Lab5_CustomerMaintenenceWPF.Views  5   	   5    /Lab5_CustomerMaintenenceWPF.Views.AddModifyPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:Lab5_CustomerMaintenenceWPF.Views     5   	   Aviews/clr-namespace:Lab5_CustomerMaintenenceWPF.Views     5   	     � Title$  Window1��5
   	   $	��320��6   $	��560��6&   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� $
��Exit��68   $��1��6P   $��4��6`   $��129,10,32,14q�6m   ��6   �� *CancelClickCommand+.��6�   Cancel5      �� 5!   
   $	��Add��68   $��4��6O   $��23,10,137,14q�6]   ��6   �� *AcceptClickCommand+.��6t   Accept5"      �� 5(   
   $
��Name��6   $��27(�6"   $��21,23,160,0q�60   $��Berlin Sans FB Bold)�6E   �� 5)   
   $��138,23,43,45q�6<   $��2��6R   $��2��6f   ��6   �� *
addModName+ �� Mode$ TwoWay=�6f   �� 5+   
   $��Address��6   $��27(�6#   $��1��61   $��21,14,128,6q�6>   $��Berlin Sans FB Bold)�6S   5,      �� 5-   
   $��137,14,44,6q�6>   $��1��6S   $��2��6`   ��6   �� *addModAddress+$ TwoWay=�.��6t   5.      �� 50   
   $
��City��6   $��27(�6    $��Berlin Sans FB Bold)�6.   $��23,10,172,13q�6O   $��2��6e   51      �� 52   
   $��2��6;   $��138,10,43,10q�6O   $��2��6e   ��6   �� *
addModCity+$ TwoWay=�.��6r   53      �� 55   
   $��State��6   $��27(�6!   $��Berlin Sans FB Bold)�6/   $��23,9,160,11q�6P   $��3��6e   56      �� 57   
   -   5        $��	cboStates��57      $��137,10,11,10q�6%   $��3��6;   58      �� 5:   
   $��Zip Code��6   $��27(�6$   $��Berlin Sans FB Bold)�62   $��1��6S   $��0,10,140,11q�6c   $��3��6x   5;      �� 5<   
   $��1��6>   $��126,10,32,10q�6N   $��3��6d   ��6   �� *addModZipCode+$ TwoWay=�.��6q   5=      5?      5@      