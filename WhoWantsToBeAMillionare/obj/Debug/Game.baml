   M S B A M L   `   `   `  ����  WhoWantsToBeAMillionare"    WhoWantsToBeAMillionare.Game   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$
  Game��5   	   $
��Auto��6   $
��Auto��6$   ��5      �� 5   
    �� ImageSource$ /Images/6.jpg��6   63   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��2* �6   �� 5      $
��1.5* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��0.5* �6    � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��3* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ FiftyJokerButton��5      $��0��6+   $��2��68   $��5q�6H   
���   ���6f   �� *FiftyJockerCommand+{�6�   �� *" CurrentLevel.fiftyJockerIsEnable+.��5      �� ��6   �� *#!CurrentLevel.fiftyJockerImgSource+5      �� 5   
   -   5        $ FriendJokerButton��5      $��0��6,   $��3��69   $��5q�6I   
���   ���6g   �� *FriendJockerCommand+{�6�   �� *#!CurrentLevel.friendJockerIsEnable+.��5      �� ��6   �� *$"CurrentLevel.friendJockerImgSource+5      �� 5   
   -   5        $ PublicJokerButton��5      $��0��6,   $��4��69   $��5q�6I   
���   ���6g   �� *PublicJockerCommand+{�6�   �� *#!CurrentLevel.publicJockerIsEnable+.��5       �� ��6   �� *$"CurrentLevel.publicJockerImgSource+5!      �� 5"   
   $��2��6;   $��2��6H   $��20q�6\   
���   �
���������6   �� *CurrentLevel.question+6{   �� 5#   
   -   5        $
 btnA��5#      $��A��6   $��3��6z   $��0��6�   $��5q�6�   
���   �
����  �
���������64   �� *AnswerCommand+��6V   �� *CurrentLevel.aA+6�   �� 5$   
   -   5        $
 btnB��5$      $��B��6   $��4��6z   $��0��6�   $��5q�6�   
���   �
����  �
���������64   �� *AnswerCommand+��6V   �� *CurrentLevel.aB+6�   �� 5%   
   -   5        $
 btnC��5%      $��C��6   $��3��6z   $��1��6�   $��5q�6�   
���   �
����  �
���������64   �� *AnswerCommand+��6V   �� *CurrentLevel.aC+6�   �� 5&   
   -   5        $
 btnD��5&      $��D��6   $��4��6z   $��1��6�   $��5q�6�   
���   �
����  �
���������64   �� *AnswerCommand+��6V   �� *CurrentLevel.aD+6�   �� 5'   
   $��1��67   $��2��6D   $��3��6T   $��4��6h   ��6   �� *CurrentLevel.imgSrc+6h   5)      5*      