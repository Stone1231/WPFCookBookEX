   M S B A M L   `   `   `  ����  CH04.ToolTips    CH04.ToolTips.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5
   
   c� .@�5      �� $
��Copy��6   $��16(�6$   $��4q�62   $��4q�5      $
��Copy��6!    � ToolTip$- 'Copy the selected text to the clipboard��5      �� 5      $��Paste��6   $��16(�6%   $��4q�63   $��4q�5      $��Paste��6!    5      _� 5      .��5      ��  �� CornerRadius$ 10��6!   $��2q�63   
���   � �� Padding$ 4q�6[   
����ح�._�5      � $	��120��6#   .+�5   "   �� $��15(�6,   $
��Wrap=�6:   $#��Paste text from the clipboard��6N   5      5      5      5      �� 5      $
��Undo��6   $
��Undo��6$   $��16(�63   $��4q�5      $��4q�6     ^� HasDropShadow .   � 	Resources 5       �� 
TargetType �� Property	 �� Value��%z   '_�       �� 5      " _�6   .�5      ��  � ��
	 ���� 67   �� 5        � ��
	 ���� 68   5!      5"       5#      �� 5$      $ 10��6   $��2q�6/   
���   �$ 4q�5%   1   
����ح�._�5'      � .+�5(      �� $��15(�6(   $
��Wrap=�66   $��Undo the last action��5)   (   5*      5+      5-      5.      �� 5/   
   
 �� AcceptsReturn
 . $��1��6'   $��14(�64   " �� VerticalScrollBarVisibility$
 Auto=�50      $ �� HorizontalScrollBarVisibility$
 Auto=�51      53      54      