   M S B A M L   `   `   `  ����D  @To-Do_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:To_Do_WPF	To_Do_WPF  5   	       To_Do_WPF.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:To_Do_WPF     5   	     � Title$  To-Do��5   	   $	��600��6   $	��400��6$    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �� $
��Auto=�6   .��5      �� .+�5      � $��10q�6   .+�5   
   �� -   5        $��AllTasks��5       �� View 5      �� 5      .P�5      ��  �� Width$ 30��6%    �� CellTemplate 5      �� 5      .R�5   "   ��  ��Name$ checkBox��6+   -   5         d� 	IsChecked 5   =   �� *IsCompleted+5   J   5      5      �� 5      $
��Name��6%   $	 150��63    �� DisplayMemberBinding 5   %   �� *Name+�� 5      $
��Date��6%   $ 80��63    5   %   �� *Date+ �� StringFormat$ {0:MM/dd/yyyy}���� 5      $
��Time��6%   $ 80��63    5   %   �� *Time+5      ��5"      �� 5#      	 �� 
TargetType"	 ��6   .�5$      -   5        5%      
 �� 
GroupStyle
 5(      (  "System.Windows.Controls.GroupStyle  5)         ContainerStyle 5*      �� 5+      "	 ��6    .�5,      ��  �� Property � �� �� Value 5-   "   �� 5.   &   .R�5/   *   9�  9� 
IsExpanded$
 True��63   ��50   .   �� 51   2    �� Orientation$ 
Horizontal=�6=   .+�52   6   �� $
��Bold"�6V   
�������$��22(�6z   $��Bottom=�6�   ��6@   �� *Name+6�   �� 53   6   $��22(�6[   
��� � �$
��Bold"�6|   $��Italic$�6�   $��10,0,0,0q�6�   $��Bottom=�6�   ��6@   �� *	ItemCount+6�   �� 54   6   $�� task(s)��6@   $��22(�6P   
�������$��Italic$�6r   $��Bottom=�6�   55   3   .��57   .   �� 58   +   59   '   5;      5<      5>      5@      5A      �� 5B   
   -   5         ��Name$ openAddWindow��5B      $��New task��6(   $��20��6;   $��60��6G   $��
300,10,0,0q�5C      6%   �� 5D   
   -   5        $ openEditWindow��5D      $��	Edit task��6)   $��20��6=   $��60��6I   $��
300,10,0,0q�5E      ��5F      ��  �� Path$ OpenEditWindowCommand� �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType" ���5I      ��  �� ElementName$ AllTasks��$ SelectedItem�5J      5K      5L      