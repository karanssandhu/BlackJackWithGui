   M S B A M L   `   `   `  ����O  KBlackJackAssignment1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:BlackJackAssignment1BlackJackAssignment1  5   	   %    BlackJackAssignment1.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:BlackJackAssignment1     5   	     � Title$  
MainWindow��5   	   $	��675��6   $
��1025��6)    � 
ResizeMode$ NoResize=�66   .��5	      � ��5
   
   �� 5       �� ImageSource$ 	/img5.png��6    � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   � -   5        $��DealerPanel��5   1   $��0��6   $��0��6$   $��Center=�6D   $	��150��6a   � 5   
   -   5        $��
ScorePanel��5   1   $��0��6   $��1��6$   $��Center=�6C   5       � 5#   
   -   5        $��PlayerPanel��5#   1   $��0��6   $��2��6$   $��Center=�6D   $	��150��6a   � 5%   
   $��0��6   $��3��6$   $��50��61   $��Bottom=�6=   $��Center=�6X   $��10q�6u   .+�5&      �� -   5        $��StartButton��5&      $��Start��6(   $��75��68   $��25��6C   $
��15 0q�6]   �� 5'      -   5        $��	HitButton��5'      $	��Hit��6&   $��75��64   $��25��6?   $
��15 0q�6W   ${�False��6e   �� 5(      -   5        $��StandButton��5(      $��Stand��6(   $��75��68   $��25��6C   $
��15 0q�6]   ${�False��6k   �� 5)      -   5        $��ResetButton��5)      $��Restart��6(   $��75��6:   $��25��6E   $
��15 0q�6_   ${�False��6m   5*      5+      5,      