   M S B A M L   `   `   `  ����n  jTelerik.Windows.Controls.Docking, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7mPclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.DockingTelerik.Windows.Controls  5   	   f bTelerik.Windows.Controls, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7uPclr-namespace:Telerik.Windows.Controls.Chromes;assembly=Telerik.Windows.Controls Telerik.Windows.Controls.Chromes 5   	   q mTelerik.Windows.Controls.Navigation, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7�^clr-namespace:Telerik.Windows.Controls.Primitives;assembly=Telerik.Windows.Controls.Navigation#Telerik.Windows.Controls.Primitives 5       NewDockingTest   NewDockingTest.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      o kTelerik.Windows.Controls.Charting, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l	 hTelerik.Windows.Controls.Input, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7r
 nTelerik.Windows.PersistenceFramework, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Data, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7o kTelerik.Windows.Controls.GridView, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7b ^Telerik.Windows.Data, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7l hTelerik.Windows.Controls.Chart, Version=2013.3.1316.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Qtelerik1http://schemas.telerik.com/2008/xaml/presentation
  	 
         5   	   wtelerikDockingPclr-namespace:Telerik.Windows.Controls;assembly=Telerik.Windows.Controls.Docking
  	 
         5   	   � Telerik_Windows_Controls_ChromesPclr-namespace:Telerik.Windows.Controls.Chromes;assembly=Telerik.Windows.Controls
  	 
         5   	   �#Telerik_Windows_Controls_Primitives^clr-namespace:Telerik.Windows.Controls.Primitives;assembly=Telerik.Windows.Controls.Navigation
  	 
         5        � Title$  Window1��5      $	��300��6   $	��300��6"    � 	Resources 5	         
paneheader �� 
TargetType1   +Telerik.Windows.Controls.Docking.PaneHeader ��Name �� CornerRadius'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� TargetProperty	 �� 
TargetName
 R� KeyTime R� Value  System.Windows.Visibility �� EndPoint � Color � Offset �Name � ColumnDefinitions ��Name �� RelativeSource.  (Telerik.Windows.Controls.RadToggleButton  Name d� IsThreeState   InnerCornerRadius �� 
TargetType �� Property �� Value �� Color3  -Telerik.Windows.Controls.Chromes.ButtonChrome  Name   RenderNormal J� IsMouseOver   RenderMouseOver   RenderPressed d� 	IsChecked    RenderChecked+  %Telerik.Windows.Controls.StyleManager!   Theme0	  *Telerik.Windows.Controls.Office_BlackTheme" F�Name(
  "Telerik.Windows.Controls.RadButton# 
 Name$ 
  InnerCornerRadius  RadPaneStyle1&    Telerik.Windows.Controls.RadPane)  #Telerik.Windows.Controls.RadTabItem  CompassStyle.   (Telerik.Windows.Controls.Docking.Compass��%�2  &	        &	 '-    &	 �1    �� 5   
   "  6-   .R�5      �� $
 Root��6   #��z��6#   #��z��6O   #��z��6�   $ 1,1,0,0��6�    5        5      CommandsMenuStates��. 5        CommandsMenuNormalState��6&     5      CommandsMenuHiddenState��. 5      �� .��5   "   T� $ 
Visibility�6@   $	 HeaderDropDownMenu��6g   ..�5   &   i� $
 0��6=    5   *    5   .   	Collapsed=�6D   5   '   5   #   5      5      5        5      PinnedStates��. 5        Unpinned��. 5      �� .��5   "   T� $ 
Visibility�6@   $	 HeaderUnPinButton��6g   ..�5    &   i� $
 0��6=    5!   *    5"   .   Visible=�6B   5$   '   5%   #   T� 5&   "   $ 
Visibility�6@   $	 HeaderPinButton��6g   ..�5'   &   i� $
 0��6=    5(   *    5)   .   	Collapsed=�6D   5+   '   5,   #   5-      5.        5/      
Pinned��6&   50        51      HighlightStates��. 52        NotHighlighted��6&     53      Highlighted��. 54      �� .��55   "   T� $ 
Background�6@   $	 Content��6g   ..�56   &   i� $
 0��6=    57   *   �� 58   .   $	 0,1&�6B   .��59   2   � $ 	#FFABABAB��6?   $ 0Q�6Q   � 5:   2   $ 	#FFF2F2F2��6?   $ 1Q�6Q   5;   /   5=   '   5>   #   5?      5@      5A      ._�5C      � $ Content��6    5D      �� 5E      $��* �6+   �� 5F      $
��Auto �6+   �� 5G      $
��Auto �6+   �� 5H      $
��Auto �6+   .+�5J      �� $ TitleElement��6%   $��0��6�   $��Stretch=�6  #��z��60  $��Center=�6S  $��Center=�6n  ��6;   �� *SelectedPane.TitleTemplate+ �� *TemplatedParent+��6�   �� *SelectedPane.Title+ �� *TemplatedParent+6n    5K      $ HeaderDropDownMenu��6.   $��1��6J   $0��*telerik:RadDockingCommands.ContextMenuOpen��6�    . $ 0��6�   ��6Z   �� *SelectedPane+ �� *TemplatedParent+��5L      �� 5M      "  6$   .�5N   "   ��  � ��$ 17��6:   �� 5O   "    � ��$ 17��6;   �� 5P   "    � ��$ 0,2,2,1q�6;   �� 5Q   "    � �� .  6>   �� 5R   "    �@J�SnapsToDevicePixels . 6H   �� 5S   "    � �� 5T   &   �� 5U   *   "  6:   .R�5V   .   �  5W   2     5X   6   CommonStates��. 5Y   :     Disabled��. 5Z   >   �� .��5[   B   T� $
 Fill�6`   $	 ForegroundIcon��6�   ..�5\   F   i� $
 0��6]    5]   J   �� 5^   N   $ 	#FF8D8D8D��6^   5`   G   5a   C   T� 5b   B   $
 Fill�6`   $	 BackgroundIcon��6�   ..�5c   F   i� $
 0��6]    5d   J   �� 5e   N   $ White��6^   5g   G   5h   C   5i   ?   5j   ;     5k   :   
Normal��6F     5l   :   	MouseOver��. 5m   >   �� .��5n   B   T� $
 Fill�6`   $	 ForegroundIcon��6�   ..�5o   F   i� $
 0��6]    5p   J   �� 5q   N   $ Black��6^   5s   G   5t   C   T� 5u   B   $
 Fill�6`   $	 BackgroundIcon��6�   ..�5v   F   i� $
 0��6]    5w   J   �� 5x   N   $ White��6^   5z   G   5{   C   5|   ?   5}   ;     5~   :   Pressed��. 5   >   �� .��5�   B   T� $
 Fill�6`   $	 ForegroundIcon��6�   ..�5�   F   i� $
 0��6]    5�   J   �� 5�   N   $ Black��6^   5�   G   5�   C   T� 5�   B   $
 Fill�6`   $	 BackgroundIcon��6�   ..�5�   F   i� $
 0��6]    5�   J   �� 5�   N   $ White��6^   5�   G   5�   C   5�   ?   5�   ;   5�   7   .+�5�   2     $ ButtonChrome��6`    .  # z 6�   # z��6�   #  z 6�   ! 5�   6   	  5�   :   5�   3   F� 5�   2   $" BackgroundIcon��67   �����        ���j     ���j @B р�[ @B р�[ �� �@KL �� �@KL ��- � 	= ��- � 	=  	= ���-  	= ���- ��- р� ��- р� �� �@B �� �@B @B �    @B 	
�������$��4��6�   $��0,2,0,0q�6�   $��7��6�   F� 5�   2   $" ForegroundIcon��67   �����        ���j     ���j @B р�[ @B р�[ �� �@KL �� �@KL ��- � 	= ��- � 	=  	= ���-  	= ���- ��- р� ��- р� �� �@B �� �@B @B �    @B 	
���   �$��4��6�   $	��0,1q�6�   $��7��6�   5�   /   5�   +   5�   #   5�      5�      � 5�      $��2��6   y�6+   �� *" SelectedPane.PinButtonVisibility+ �� *TemplatedParent+.+�5�      
  $# HeaderPinButton��6,   $$��telerik:RadDockingCommands.Pin��6�   $$ 0��6�   ��6E   �� *SelectedPane+ �� *TemplatedParent+��5�      �� 5�   "   " 
 6(   .�5�   &   ��  � ��$ 17��6>   �� 5�   &    � ��$ 17��6?   �� 5�   &    � ��$ 0,2,2,1q�6?   �� 5�   &    � �� .  6B   �� 5�   &    �@J�SnapsToDevicePixels . 6L   �� 5�   &    � �� 5�   *   �� 5�   .   " 
 6>   .R�5�   2   �  5�   6     5�   :   CommonStates��. 5�   >     Disabled��. 5�   B   �� .��5�   F   T� $ Stroke�6d   $	 ForegroundIcon��6�   ..�5�   J   i� $
 0��6a    5�   N   �� 5�   R   $ 	#FF8D8D8D��6b   5�   K   5�   G   T� 5�   F   $ Stroke�6d   $	 BackgroundIcon��6�   ..�5�   J   i� $
 0��6a    5�   N   �� 5�   R   $ White��6b   5�   K   5�   G   5�   C   5�   ?     5�   >   
Normal��6J     5�   >   	MouseOver��. 5�   B   �� .��5�   F   T� $ Stroke�6d   $	 ForegroundIcon��6�   ..�5�   J   i� $
 0��6a    5�   N   �� 5�   R   $ Black��6b   5�   K   5�   G   T� 5�   F   $ Stroke�6d   $	 BackgroundIcon��6�   ..�5�   J   i� $
 0��6a    5�   N   �� 5�   R   $ White��6b   5�   K   5�   G   5�   C   5�   ?     5�   >   Pressed��. 5�   B   �� .��5�   F   T� $ Stroke�6d   $	 ForegroundIcon��6�   ..�5�   J   i� $
 0��6a    5�   N   �� 5�   R   $ Black��6b   5�   K   5�   G   T� 5�   F   $ Stroke�6d   $	 BackgroundIcon��6�   ..�5�   J   i� $
 0��6a    5�   N   �� 5�   R   $ White��6b   5�   K   5�   G   5�   C   5�   ?   5�   ;   .+�5�   6      .  # z 6y   # z��6�   ! 5�   :   	  5�   >   5�   7   F� 5�   6   $" BackgroundIcon��6;   s����    �.c ���j �.c �`� �.c �`� `� Ѡ%&  � � �D  � �`�S `� �`�S �.c ��g5 �.c ��g5 ��� � �D �.c � �D  � 	$��10��6�   $��0,2,0,0q�6�   
�������$��1��6�   $��7��6�   F� 5�   6   $" ForegroundIcon��6;   s����    �.c ���j �.c �`� �.c �`� `� Ѡ%&  � � �D  � �`�S `� �`�S �.c ��g5 �.c ��g5 ��� � �D �.c � �D  � 	$��10��6�   $	��0,1q�6�   
���   �$��1��6�   $��7��6�   5�   3   5�   /   5�   '   5�   #   5�      
  5�      $# HeaderUnPinButton��6,   $$��telerik:RadDockingCommands.Pin��6�   $$ 0��6�   $y�	Collapsed=�6�   ��6G   �� *SelectedPane+ �� *TemplatedParent+��5�      �� 5�   "   " 
 6(   .�5�   &   ��  � ��$ 17��6>   �� 5�   &    � ��$ 17��6?   �� 5�   &    � ��$ 0,2,2,1q�6?   �� 5�   &    � �� .  6B   �� 5�   &    �@J�SnapsToDevicePixels . 6L   �� 5�   &    � �� 5�   *   �� 5   .   " 
 6>   .R�5  2   �  5  6     5  :   CommonStates��. 5  >     Disabled��. 5  B   �� .��5  F   T� $ Stroke�6d   $	 ForegroundIcon��6�   ..�5  J   i� $
 0��6a    5  N   �� 5	  R   $ 	#FF8D8D8D��6b   5  K   5  G   T� 5  F   $ Stroke�6d   $	 BackgroundIcon��6�   ..�5  J   i� $
 0��6a    5  N   �� 5  R   $ White��6b   5  K   5  G   5  C   5  ?     5  >   
Normal��6J     5  >   	MouseOver��. 5  B   �� .��5  F   T� $ Stroke�6d   $	 ForegroundIcon��6�   ..�5  J   i� $
 0��6a    5  N   �� 5  R   $ Black��6b   5  K   5  G   T� 5   F   $ Stroke�6d   $	 BackgroundIcon��6�   ..�5!  J   i� $
 0��6a    5"  N   �� 5#  R   $ White��6b   5%  K   5&  G   5'  C   5(  ?     5)  >   Pressed��. 5*  B   �� .��5+  F   T� $ Stroke�6d   $	 ForegroundIcon��6�   ..�5,  J   i� $
 0��6a    5-  N   �� 5.  R   $ Black��6b   50  K   51  G   T� 52  F   $ Stroke�6d   $	 BackgroundIcon��6�   ..�53  J   i� $
 0��6a    54  N   �� 55  R   $ White��6b   57  K   58  G   59  C   5:  ?   5;  ;   .+�5=  6      .  # z 6y   # z��6�   ! 5>  :   	  5?  >   5A  7   F� 5B  6   $" BackgroundIcon��6;   s�����g5     ��g5 ��j ��g5 `� � �� `� �`�� �%& �`��  �D � �� `�S ��g5 `�S ��g5 �g5 �    �g5 ��g5  �D �`��  �D 	$��7��6�   $��0,2,0,0q�6�   
�������$��1��6�   $��10��6�   F� 5C  6   $" ForegroundIcon��6;   s�����g5     ��g5 ��j ��g5 `� � �� `� �`�� �%& �`��  �D � �� `�S ��g5 `�S ��g5 �g5 �    �g5 ��g5  �D �`��  �D 	$��7��6�   $	��0,1q�6�   
���   �$��1��6�   $��10��6�   5D  3   5E  /   5G  '   5H  #   5J     5K     
  5L     $# HeaderCloseButton��6(   $��3��6C   $&�� telerik:RadDockingCommands.Close��6�   $$ 0��6�   ��6S   �� *SelectedPane+ �� *TemplatedParent+��5M     �� 5N     " 
 6$   .�5O  "   ��  � ��$ 17��6:   �� 5P  "    � ��$ 17��6;   �� 5Q  "    � ��$ 0,2,2,1q�6;   �� 5R  "    � �� .  6>   �� 5S  "    �@J�SnapsToDevicePixels . 6H   �� 5T  "    � �� 5U  &   �� 5V  *   " 
 6:   .R�5W  .   � $ 
LayoutRoot��63    5X  2     5Y  6   CommonStates��. 5Z  :     Disabled��. 5[  >   �� .��5\  B   T� $
 Fill�6`   $	 ForegroundIcon��6�   ..�5]  F   i� $
 0��6]    5^  J   �� 5_  N   $ 	#FF8D8D8D��6^   5a  G   5b  C   T� 5c  B   $
 Fill�6`   $	 BackgroundIcon��6�   ..�5d  F   i� $
 0��6]    5e  J   �� 5f  N   $ White��6^   5h  G   5i  C   5j  ?   5k  ;     5l  :   
Normal��6F     5m  :   	MouseOver��. 5n  >   �� .��5o  B   T� $
 Fill�6`   $	 ForegroundIcon��6�   ..�5p  F   i� $
 0��6]    5q  J   �� 5r  N   $ Black��6^   5t  G   5u  C   T� 5v  B   $
 Fill�6`   $	 BackgroundIcon��6�   ..�5w  F   i� $
 0��6]    5x  J   �� 5y  N   $ White��6^   5{  G   5|  C   5}  ?   5~  ;     5  :   Pressed��. 5�  >   �� .��5�  B   T� $
 Fill�6`   $	 ForegroundIcon��6�   ..�5�  F   i� $
 0��6]    5�  J   �� 5�  N   $ Black��6^   5�  G   5�  C   T� 5�  B   $
 Fill�6`   $	 BackgroundIcon��6�   ..�5�  F   i� $
 0��6]    5�  J   �� 5�  N   $ White��6^   5�  G   5�  C   5�  ?   5�  ;   5�  7   .+�5�  2      .  # z 6u   # z��6�   ! 5�  6   	  5�  :   5�  3   F� 5�  2   $" BackgroundIcon��67   �����        р�     р� @B ���- @B ���- �� �@KL �� �@KL @B р�[ @B р�[     � z     � z @B ���j @B ���j �� р�[ �� р�[ ��- �@KL ��- �@KL  	= р�[  	= р�[ @KL р�[ @KL ���j @KL ���j ��[ � z ��[ � z ��j р�[ ��j р�[ ��[ �@KL ��[ �@KL @KL ���- @KL ���- ��[ р� ��[ р� ��j �    ��j �    ��[ �@B ��[ �@B @KL р� @KL р�  	= ���-  	= ���- ��- р� ��- р� �� �@B �� �@B @B �    @B 	
�������$��7��6  $��0,2,0,0q�6$  $��8��65  F� 5�  2   $" ForegroundIcon��67   �����        р�     р� @B ���- @B ���- �� �@KL �� �@KL @B р�[ @B р�[     � z     � z @B ���j @B ���j �� р�[ �� р�[ ��- �@KL ��- �@KL  	= р�[  	= р�[ @KL р�[ @KL ���j @KL ���j ��[ � z ��[ � z ��j р�[ ��j р�[ ��[ �@KL ��[ �@KL @KL ���- @KL ���- ��[ р� ��[ р� ��j �    ��j �    ��[ �@B ��[ �@B @KL р� @KL р�  	= ���-  	= ���- ��- р� ��- р� �� �@B �� �@B @B �    @B 	
���   �$��7��6  $	��0,1q�6$  $��8��61  5�  /   5�  +   5�  #   5�     5�     5�     5�     5�     �� 5�  
   "  6&   .�5�     ��  � �� 5�     �� 5�     "  6&   .R�5�     � $ wrapper��6   5�     5�     5�     �� 5�      �@ LeftTemplate 5�     �� 5�     "  6&   .R�5�     � $ wrapper��6   5�     5�     5�     �� 5�      �@ TopTemplate 5�     �� 5�     "  6&   .R�5�     � $ wrapper��6   $��0,0,-1,0q�60   5�     5�     5�     �� 5�      �@ RightTemplate 5�     �� 5�     "  6&   .R�5�     � $ wrapper��6   5�     5�     5�     �� 5�      �@ BottomTemplate 5�     �� 5�     "  6&   .R�5�     � $ wrapper��6   $��0,4,-1,0q�60   5�     5�     5�     �� 5�      �@ DocumentHostTemplate 5�     �� 5�     "  6&   .R�5�     � $ wrapper��6   $��0,0,-1,0q�60    5�     �� 5�  "   $��* �63   �� 5�  "   $
��Auto �63   5�     5�     5�     �� 5�      � ��$ 0q�60   �� 5�      � �� �	#FF8484846,   �� 5�      � ��
 ���� 6+   �� 5�      � ��
 �   �6+   �� 5�      � ��$ 0q�6(   �� 5�      � ��$ 0q�6'   5�     �� 5�  
   "  6%   .�5�     ��  � ��$ 1��6&   �� 5�      � ��$ 1��6'   �� 5�      � �� 5�     �� 5�     "  6&   .R�5�     �� $ 
VisualRoot��6!   #��z��65   #��z��6a   #��z��6�   5�     5�     5      5     5     .��5     � .+�5  
   )   #Telerik.Windows.Controls.RadDocking  -   5        %  Name$% dashboardDocking��5  R   &   CompassStyle#& [ 6$   $y�Visible=�6l   $��0��6�   $��0,0,0,0q�6�   '   HasDocumentHost' .  $��0q�6�   .@�5     0   *Telerik.Windows.Controls.RadSplitContainer  .@�5     +   %Telerik.Windows.Controls.RadPaneGroup  .@�5       -   5        (  Name$( navPane��5  :   $	��one��6-   5
     5       5     .@�5       $	��two��6-   #��[ 6:   .��5       -   5        $% dashboardDocking1��5  5   $y�Visible=�6P   $��0��6e   $��0,0,0,0q�6r   ' .  $��0q�6�   .@�5       .@�5  "     .@�5  &     $	��one��6=   6L   5  #     5  "   .@�5  &     $	��two��6=   6L   5  #     5  "   .@�5  &     $��three��6=   6N   5  #   5     5#     5%     5&     5)     5.     51     52     