   M S B A M L   `   `   `  ����  NewDockingTest    NewDockingTest.UpdateTest   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      o kTelerik.Windows.Controls.Charting, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l hTelerik.Windows.Controls.Input, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r nTelerik.Windows.PersistenceFramework, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Data, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n	 jTelerik.Windows.Controls.Docking, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7f
 bTelerik.Windows.Controls, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GridView, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.Navigation, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Data, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l hTelerik.Windows.Controls.Chart, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Qtelerik1http://schemas.telerik.com/2008/xaml/presentation
     	 
     5   	     � Title$  
UpdateTest��5      $	��300��6   $	��300��6%    � 	Resources 5         cc1 �� 
TargetType- 
 'Telerik.Windows.Controls.RadProgressBar'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard g� RepeatBehavior g� Duration �� TargetProperty	 �� 
TargetName
 R� KeyTime R� Value  System.Windows.Visibility g� 	BeginTime O� KeyTime O� Value F�Name J� RenderTransformOrigin � FillRule @� Center @� RadiusY @� RadiusX �� EndPoint �� 
StartPoint � Color � Offset 
� Center 
� GradientOrigin 
� RadiusY 
� RadiusX �Name J� Clip � ColumnDefinitions  �� Angle! ��Name��%�  &	        �� 5   
   "  6&   .R�5      �  5	        5
      CommonStates��. 5        Determinate��6&     5      Indeterminate��. 5      �� $ Forever��6)   .��5   "   T� $ 0D�6@   $ (UIElement.Visibility)�6M   $	 IndeterminateDonut��6�   ..�5   &   i� $
 0��6=    5   *    5   .   Visible=�6B   5   '   5   #   U� 5   "   $ 0X�6@   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(RotateTransform.Angle)�6N   $	 IndeterminateDonut��6�   .\�5   &   �� $ 0:0:1��6;   $	 360Q�6K   5   #   5      5      5      .+�5      F� $" IndeterminateBackgroundDonut��6   $��44��6=   $ 0.5,0.5&�6I   ���	#FFBAD4F4$��44��6|   ��5      � 5      $ EvenOdd=�6(   .��5      @� $ 22,22&�6.   $ 20Q�6=   $ 20Q�6J   @� 5       $ 22,22&�6.   $ 14Q�6=   $ 14Q�6J   5!      ��5#      �� 5$      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5%      � $ 	#FF587BA5��6+   $ 0Q�6=   � 5&      $ 	#FFDFEEFF��6+   $ 1Q�6=   � 5'      $ 	#FFD0DFF0��6+   $ 0.254Q�6=   � 5(      $ 	#FF587BA5��6+   $	 0.5Q�6=   5)      5+      F� 5,      $ IndeterminateDonut��6   $��44��63   $ 0.5,0.5&�6?   $y�	Collapsed=�6_   $��44��6v   ��5-      � 5.      $ EvenOdd=�6(   .��5/      @� $ 22,22&�6.   $ 20Q�6=   $ 20Q�6J   @� 50      $ 22,22&�6.   $ 14Q�6=   $ 14Q�6J   51      ��53      
� 54      $ 	0.5,-0.23&�6.   $ 0.8,0.25&�6A   $
 0.68Q�6[   $
 0.68Q�6j   .��55      � $ 	#BFFFFFFF��6+   $ 0Q�6=   � 56      $ Transparent��6+   $ 1Q�6?   � 57      $ 	#21FFFFFF��6+   $
 0.65Q�6=   58      z�5:      V� 5;      .~�5<      �� 5=      5?      � 5@      $ ProgressBarTrack��6   $��24��61   $ 0.5,0.5&�6=   $��24��6]    5A      @� 5B      $ 12,12&�6*   $ 12Q�69   $ 12Q�6F    5D      �� 5E      $
��Auto �6+   �� 5F      $
��Auto �6+   �� 5G      $��* �6+   z�5I      �� 5J      $	  -90Q�6*   .+�5L      �� $! SkipValueSpacer��6    �� 5M      $! ProgressBarIndicator��6    $��1��6>   ���	#FFBAD4F46N   5N      5O      5P      5Q      .��5R      � .+�5S   
   �� .+�5T      �� -   5        " ��Name$
" btn1��5T      $��Update��6#   $
��Left=�64   $	��Top=�6O   6~   �� 5U      -   5        $
��txb1��5U      $��Ready��6$   $y�	Collapsed=�61   6J     5W      -   5        #  Name$	# bi1��5W   %   $   IsIndeterminate$ . + 
 %Telerik.Windows.Controls.StyleManager%   Theme- 
 'Telerik.Windows.Controls.ThemeConverter$% Windows7 6I   #��[  6o   $y�	Collapsed=�6�   6�   5Z      5[      5\      