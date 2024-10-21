# PVZ win rate eval

## We have a some row with plants, zombie and void sections

<img src="pvz_.jpg">

## What is win rate? Win rate - is distance between last plant & first zombie

<img src="pvz.jpg">

## Use script
### 0.5. in pvz-system.fsx
### 1. Write plants, zombies and voids to constant 'sections' :
```f#
    let sections = [
        (* Non - void *)
        Plant; Plant; Plant; Non; Non; Plant; Zombie; Non; Zombie
    ]
```
### 2. Init main eval function :
```f#
    let my_win_rate =
        PVZ.getWinRate (
            9 (* row length *), sections, false (* enable debug *)
        ) * 10 (* resize to more readable digit *)
```
### 3. Start script with Fsi :
```shell
dotnet fsi pvz-system.fsx
```
### 4. End :
    Start eval              [1]
    End eval                [1]

    Result win-rate: 30% / 3%

## SORRY, i\'m use #nowarn for FS0064 warning. To delete this goto src/system.fsx, after delete his :
```f#
#nowarn "0064"
```