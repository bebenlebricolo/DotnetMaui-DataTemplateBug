[DataTemplate/CollectionView] BUG : inconsistent behavior between Debug/Release modes in .Net Maui

Steps : 
1. clone this repo, checkout the main branch. This branch is in the "broken" state
2. Build the solution in Debug mode and run it on an Android device (either physical or emulator)
   -> Items are displayed correctly in the CollectionView
3. Build the solution in Release mode and run it on an Android device
   -> Items are **not** displayed !
4. Checkout the branch "fixed"
5. Repeat the steps 2 to 3
   -> In Release mode, now items are correctly listed !

The change essentially boils down to :
```xaml
++ <DataTemplate x:DataType="datamodels:CustomViewModel">  <!-- Functional state -->
-- <DataTemplate>  <!-- Broken state -->
```    



