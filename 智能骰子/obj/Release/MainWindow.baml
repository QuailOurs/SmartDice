   M S B A M L   `   `   `  ����   	TRPGTools    TRPGTools.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     -     �Name$  Window�� � 
ResizeMode$ NoResize=�$��宋体)� � Title$ 
TRPG Tools��$	��450��$	��525�� � Icon$ Images/64X64.ico�� � 	Resources ��%    .��� -    �Name$ 
LayoutRoot��$��Stretch=�$��Stretch=� � RowDefinitions �� $��65 ��� $��25 ��� $
��444* ��� $
��Auto � � ColumnDefinitions �� $
��156* ��� $
��359* ��� $
��263* �.+�]� $��0��$��0����.   J� OpacityMask �	#FFC7EDCC$��0q�.+�� $	��103��$
��Auto��$��0,2,0,0q�$��Center=�.+�� $��Center=�$��	10,4,13,0q�$��Center=�$��80��.+��� $
��Wrap=�$��
TRPG
Tools��$��15(�$
��Bold"�$��38,9,0,7q��� $	��Top=�$
��Fill=�$��0,9,0,0q�$��35��$
��Left=�$��35��$��Images/64X64.ico��o� -   $
��menu��$��1��$��15(�
�������$��	0,21,0,20q�$��Center=�$��2��.@�m� -   $��miStart��$��功能��.@�m� -   $��mi_new��$��TRPG简易骰子���� m� -   $��MiExit��$��退出��m� -   $��miAbout��$��关于��m� -   $��mi_setParameter��$��设置��.@�m� -	   $��miSetDataBase��$��设置���� -
   $��sb_cur��$��1��$��1��$��2��$��25��$	��Top=�.@��� $��当前功能: ��$��Center=��� -   $��tb_curTools��$�� ���� -   $��sbMain��$��3��$��3��$��27��$��Bottom=�.@��� ���� 	 �� ElementName$	 CategoryTree��
 �� Path$
 SelectedItem.CategoryName��� -   $��addContentControl��$��Stretch=�$��Stretch=�$��1��$��2��$��2��$��Stretch=�$��Stretch=�$��0,0,0,0q�