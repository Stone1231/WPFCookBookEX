   M S B A M L   `   `   `  ����L  HCH06.DataGridDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:CH06.DataGridDemoCH06.DataGridDemo  5   	   "    CH06.DataGridDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   1localclr-namespace:CH06.DataGridDemo     5   	   6sys&clr-namespace=System,assembly=mscorlib     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5         
genderEnum S� 
MethodName S� 
ObjectType   CH06.DataGridDemo.Gender S� MethodParameters M� Type��%e   &	        S� 5	   
   $ 	GetValues��60   "  6G    5
      M� 5      "  6   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��3* �6   �� 5      $
��Auto �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  ��6   �� 5        5   
   -   5        $��1��5   +   ��6   ��    Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Avatar��6)   	   CellTemplate	 5      �� 5      .R�5      �� 
 �� Orientation$
 
Horizontal=�6)   .+�5    "   �� $��2q�6(   $��32��63   $��32��6>   ��6J   �� *Avatar+�� 5!   "   $
��Test��6,   5"      5#      5%      5'        5)   
   $��2��6+      AutoGenerateColumns .  ��6   ��  5*      4  .System.Windows.Controls.DataGridComboBoxColumn  5+      $ Gender��6)      SelectedItemBinding 5,   )   �� *Gender+   ItemsSource 5-   )   ��  �� Source# [  0  *System.Windows.Controls.DataGridTextColumn  5.      $ 
First Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *	FirstName+  5/      $ 	Last Name��6%    68   �� *
LastName+  50      $ Email��6)   	 51      �� 52      .R�53      �� �� 54   "   -   5        ��54   ,   �� *Email+.�55   5   .�56   "   �� �6&   �� *Email+ �� Mode$ OneWay=�57   #   58      59      5;      4  .System.Windows.Controls.DataGridCheckBoxColumn  5<      $ 	Employed?��6)    6<   �� *
IsEmployed+5>      5@      5B      