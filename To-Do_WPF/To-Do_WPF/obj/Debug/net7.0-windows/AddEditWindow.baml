   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   D @To-Do_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:To_Do_WPF	To_Do_WPF 5   	      To_Do_WPF.AddEditWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:To_Do_WPF     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Add/Edit��5
   	   $	��600��6   $	��400��6'    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         MyWaterMarkStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name ��Name
	 � Tag
 �� Triggers ]� 
Conditions �� Property �� Value �� 
TargetName P� Property P� Value��%�  &	        �� 5   
   " ��6)   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� 
����������	#FF7D8683$��1q�5   %   �� 5      $ PART_ContentHost��6+   $��5,0,0,0q�6E   $��Center=�5   +   �� 5      $ WaterMarkLabel��65   $��5,0,0,0q�6$   #��z	 5   $   $	��Top=�6D   $y�	Collapsed=�5   $   
�������$��Arial)�5   $   5      
 5      ]� 5       5   "   �� 5   &    � ��$  ��6@   ./�5    "   �� $ WaterMarkLabel��5!   )    � y�$ Visible=�6E   5"      P� 5#       � {�$ False��6;   . �5$   "   ��  � ��
 �iii�6?   5%      5'      5)      5*      5+      .��5,      �� .+�5-   
   �� -   5         ��Name$ addTaskName��5-      #��[  5.      $��10,20,10,10q�5/      $��18(�6'   
�������$	 	Task name��50      $��30��6"    �� 	MaxLength$ 35��6.   �� 52   
   -   5        $ addTaskNote��52      $��10,20,10,10q�6'   $��18(�6<   
�������$	��115��53   *   #��[  54      $	 Add note (optional)��6<   $	��Top=�55      $
��Auto=�6*    �� TextWrapping$
 Wrap=�56      �� 58   
   
�������
�������$��2q�6;   ._�59      ��  �� Orientation$ 
Horizontal=�6   .+�5:      (  "System.Windows.Controls.DatePicker  -   5          Name$ addTaskDate��5:      $��25��62   $��30��6>   $��10q�6I   "  Xceed.Wpf.Toolkit.TimePicker  5;      -   5          Name$ addTaskTime��5;   "   $��25��67   $��70��6C   $��10q�6N   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text$  ��6Z   �� 5<      -   5         ��Name$ addTaskRemider��5<      $��Remind��61   $��25��6B   $��50��6N   $��10q�5=      6%   �� 5>      -   5        $ 
addTaskBtn��5>      $
��Save��6-   $��25��6<   $��30��6H   $��130,10,0,10q�5?      6.   5@      5A      5B      5C      