   M S B A M L   `   `   `  ����D  @SampleAdo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SampleAdo	SampleAdo  5   	       SampleAdo.EmpDetails   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SampleAdo     5   	   -   5          � Title$  Employee Form��5   	   $	��450��6   $	��525��6,   .��5	      � $��0,0,-0.333,-19.333q�6   .+�5
   
   �� -   5         ��Name$ 	lbl_empId��5
      $��Employee Id��6#   $
��Left=�69   $��	77,43,0,0q�6T   $	��Top=�6g   �� 5   
   -   5         ��Name$ 	txt_empId��5      $
��Left=�6%   $��23��6@   $��
197,43,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   {�.  6�   �� 5   
   -   5        $ 	lbl_eName��5      $��Employee Name��6#   $
��Left=�6;   $��	77,88,0,0q�6V   $	��Top=�6i   �� 5   
   -   5        $ 	txt_eName��5      $
��Left=�6%   $��23��6@   $��
197,88,0,0q�6L   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ lbl_eLoc��5      $��Employee Location��6"   $
��Left=�6>   $��
77,138,0,0q�6Y   $	��Top=�6m   �� 5   
   -   5        $ txt_eLoc��5      $
��Left=�6$   $��23��6?   $��197,137,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   -   5        $ lbl_ePh��5      $��Employee Contact��6!   $
��Left=�6<   $��
77,188,0,0q�6W   $	��Top=�6k   �� 5   
   -	   5        $ txt_ePh��5      $
��Left=�6#   $��23��6>   $��199,188,0,0q�6J   $
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��120��6�   �� 5   
   -
   5         ��Name$ 
btn_addEmp��5      $��Add Employee��6%   $
��Left=�6<   $��
401,79,0,0q�6W   $	��Top=�6k   $��98��6�    J� RenderTransformOrigin$ 0.467,1.802&�6�   $��32��6�   6�   �� 5   
   -   5        $ 	btn_reset��5      $��Reset��6$   $
��Left=�64   $��401,138,0,0q�6O   $	��Top=�6d   $��98��6|   $ 
0.05,0.808&�6�   $��30��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg_Emp��5      $
��Left=�6#   $��
77,255,0,0q�6>   $	��Top=�6R   $	��133��6j   $	��363��6w   5      5      