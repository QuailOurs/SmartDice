   M S B A M L   `   `   `  ����  智能骰子    智能骰子.UC_SmartDice   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $	��374��5   #   .��5      �   � RowDefinitions  5	   
   �� 5
      $	��40* �6   �� 5      $
��100* �6   .+�5   
   �� -   5        $��bt_roll��5      $��0��6   $
��Roll��6-   $
��Left=�6<   $��	213,7,0,0q�6W   $	��Top=�6j   $	��154��6�   $	��107��6�   �� 5   
   $��	# of Dice��6   $
��Left=�6$   $��8,63,0,0q�6?   $	��Top=�6Q   �� 5   
   -   5        $��cb_countOfDice��5       $��0��6   $
��Left=�66   $��	14,88,0,0q�6Q   $	��Top=�6d   $��50��6|   �� 5   
   -   5        $��tb_diceExpression��5   !   $��0��6   $
��Left=�6:   $��8,8,0,0q�6U   $
��Wrap=�6f   $��0��6z   $	��Top=�6�   $��52��6�   $��42��6�   $��Disabled=�6�   $��48(�6�    �� TextAlignment$ Center=�6�   &   System.Windows.Media.TextOptions   TextHintingMode$ Animated=�6  $��Medium"�62  �� 5   
   $��	Dice Type��6   $
��Left=�6$   $	��Top=�6?   $��	82,63,0,0q�6W   �� 5   
   -   5        $��cb_diceType��5       $��0��6   $
��Left=�63   $��	90,88,0,0q�6N   $	��Top=�6a   $��50��6y    J� RenderTransformOrigin$ 
0.72,0.364&�6�   �� 5   
   $��Total��6   $
��Left=�6    $��
166,27,0,0q�6;   $	��Top=�6O   �� 5   
   -   5        $��tb_total��5   !   $��0��6   $
��Left=�61   $��
166,53,0,0q�6L   $
��Wrap=�6`   $��0��6t   $	��Top=�6}   $��41��6�   $��42��6�   $��Disabled=�6�   $��36(�6�   $ Center=�6�   &   System.Windows.Controls.DataGrid  5    
   -   5        $��dg_rollResult��5    O   $��1��6      AutoGenerateColumns .  $��	8,10,7,10q�6<      
IsReadOnly . ��6d   ��    Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$  序号��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 10* 62   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6>   �� *
CountNum+  5#      $ 
 总点数��6%   $	 20* 63   	 6?   �� *
PointCount+  5$      $  各骰子点数��6%   $	 35* 65   	 6A   �� *PointString+  5%      $  骰子公式��6%   $	 35* 64   	 6@   �� *PointString+5'      5)      5*      