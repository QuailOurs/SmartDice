   M S B A M L   `   `   `  ����   	TRPGTools    TRPGTools.UC_SmartDice   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   $	��365��$	��290��.���   � RowDefinitions  �� $	��40* ��� $	��60* �.+��� -   $��bt_roll��$��0��$
��Roll��$
��Left=�$��	213,7,0,0q�$	��Top=�$��55��$	��143���� $��	# of Dice��$
��Left=�$��8,63,0,0q�$	��Top=��� -   $��cb_countOfDice��$��0��$
��Left=�$��	14,88,0,0q�$	��Top=�$��50������ .R���  �� Orientation$ 
Horizontal=�.+��� ���� *num+�� -   $��tb_diceExpression��$��0��$
��Left=�$��14,7,0,0q�$
��Wrap=�$�� ��$	��Top=�$��Disabled=�$��48(� �� TextAlignment$ Center=�$
��Bold"�$��Arial Black)��� $��	Dice Type��$
��Left=�$	��Top=�$��	83,63,0,0q��� -   $��cb_diceType��$��0��$
��Left=�$��	90,88,0,0q�$	��Top=�$��50�� J� RenderTransformOrigin$ 
0.72,0.364&��� $��Total��$
��Left=�$��
265,63,0,0q�$	��Top=��� -   $��tb_total��$��0��$
��Left=�$��
230,88,0,0q�$
��Wrap=�$��0��$	��Top=�$��28��$	��117��$��Disabled=�$��20(�$ Center=�$��Courier New)�$
��Bold"��� $��Throw Counter��$
��Left=�$	��Top=�$��
149,63,0,0q��� -    ��Name$ cb_throwCounter��$��0��$
��Left=�$��
166,88,0,0q�$	��Top=�$��50��$ 
0.72,0.364&�&   System.Windows.Controls.DataGrid  -   $��dg_rollResult��$��1��   AutoGenerateColumns .  $��	8,10,8,43q�   
IsReadOnly . ����    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$  #��	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 10* 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 �� *
CountNum+  $ 
 总点数��$		 25* 
 �� *
PointCount+  $  各骰子点数��$		 65* 
 �� *PointString+  $  骰子公式��$		 25* 
 �� *
DiceString+�� $��上一次 :��$
��Left=�$��	4,138,0,0q�$	��Top=�$��1���� -	   $��tb_previous��$��1��$
��Left=�$��
62,138,0,0q�$
��Wrap=�$�� ��$	��Top=�$��28��$	��285��$��Disabled=�$��10(�$��Courier New)�