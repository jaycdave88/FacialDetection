   M S B A M L   `   `   `  ����J  FFacialDetection, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FacialDetectionFacialDetection  5   	        FacialDetection.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FacialDetection     5   	   -   5          � Title$  
MainWindow��5   	   $	��600��5	   	   $	��800��5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��380 �6   �� 5      .+�5   
   �� -   5         ��Name$ 
tabControl��5      $
��Left=�5      $	��440��5      $��
60,111,0,0q�5      $	��Top=�5      $	��678��5      $��2��5       �� SelectedIndex$ 1��5      .@�5      �� -   5         ��Name$
 tab1��5      $��TabItem��5      .��5      � ���	#FFE5E5E56   5      �� 5      -   5        $
 tab2��5      $��OpenCV��5      .��5      � ���	#FFE5E5E5 5       �� 5!      $	��41* �6+   �� 5"      $	��55* �6+   .+�5$      �� -   5        $��	imgOpenCV��5$      $
��Fill=�5%      $��2��5&      $��0,0,-0.444,0q�5'      5(      5)      5*      �� 5+   
   -   5         ��Name$ lbStat��5+      $��Stats:��5,      $
��Left=�5-      $��	41,23,0,0q�5.      $	��Top=�5/      $��41��50      $��73��51      $��26.667(�52      �� 54   
   -   5        $ lblStatInfoCPU��54      $
��Left=�55      $��
129,10,0,0q�56      $	��Top=�57      $��31��58      $	��191��59      $��16(�5:      $��LINE_FOR_CPU_DATA��5;      �� 5<   
   -   5        $ lblStatInfoTotalFaces��5<      $
��Left=�5=      $��
129,80,0,0q�5>      $	��Top=�5?      $��31��5@      $	��191��5A      $��16(�5B      $��LINE_FOR_TOTAL_FACES��5C      �� 5D   
   -	   5        $ lblStatMemory��5D      $
��Left=�5E      $��
129,44,0,0q�5F      $	��Top=�5G      $��31��5H      $	��191��5I      $��16(�5J      $��LINE_FOR_MEMORY��5K      5M      5N      