   M S B A M L   `   `   `  ����  NewDockingTest     NewDockingTest.winHasItems   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      o kTelerik.Windows.Controls.Charting, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l hTelerik.Windows.Controls.Input, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r nTelerik.Windows.PersistenceFramework, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Data, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.Docking, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7f
 bTelerik.Windows.Controls, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GridView, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.Navigation, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Data, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l hTelerik.Windows.Controls.Chart, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Qtelerik1http://schemas.telerik.com/2008/xaml/presentation
     	 
     5   
     � Title$  winHasItems��5      $	��300��6   $	��300��6&    � 	Resources 5         	boolToVis��%   &	        �� 5   
   6'   5      .��5	      �  � RowDefinitions 5
   
   �� 5      $��50 �6   6*   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ btnAdd��5      $	��Add��6%   $
��Left=�63   $	��Top=�6N   $	��100��6f   6�   �� 5      -   5        $ 	btnRemove��5      $��Remove��6(   $
��Left=�69   $	��Top=�6T   $	��100��6l   6�   5      �� 5   
   $��1��6x   y�6   ��  �� ElementName$ radGridView�� �� Path$ HasItems� �� 	Converter# [  Grid Has Items6�   *  $Telerik.Windows.Controls.RadGridView  5   
   -   5          Name$ radGridView��5      ;  5Telerik.Windows.Controls.GridView.GridViewDataControl	   AutoGenerateColumns	 .  $��2��6O   
   Columns
 5      1  +Telerik.Windows.Controls.GridViewDataColumn  5      6  0Telerik.Windows.Controls.GridViewBoundColumnBase   Header$
 Name��6P      DataMemberBinding 6-   �� *Name+6P   5      5      5      