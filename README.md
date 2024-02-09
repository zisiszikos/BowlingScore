# Bowling score

## Scoring Rules
- There are 10 turns called frames. Each frame begins with 10 pins, and the bowler gets up to two tries to knock them all over.
- One point is scored for each pin that is knocked over, and when fewer than all ten pins are knocked down in two rolls in a frame (an open frame), the frame is scored with the total number of pins knocked down.
- Strike: When all ten pins are knocked down on the first roll, the frame receives ten pins plus the next two rolls (not frames!). A strike in the tenth (final) frame receives two extra rolls as a bonus.
- Spare: When the second roll of a frame knocks down all pins, the frame receives ten pins plus the next roll. A spare in the tenth (final) frame receives a third roll as a bonus.
- Bonus pins: No additional rolls are received for a strike/spare in the bonus balls.

## Usage
Provide a list of rolls as arguments. The program will print the result score
```
$ dotnet run 2,3,2,8,4,5 verbose
Rolls: 2, 3, 2, 8, 4, 5
Total score: 28
```
or
```
$ dotnet run 2,3,2,8,4,5
28
```
