using System;

namespace ScratchMini {
    class Main
    {
        static void Main()
        {
            
        }
    }
    class Program
    {
        String name;
        List <ICommand> Commands;
        Field currentField;

        void Execute();
        
    }

    interface ICommandLine
    {
        Program basicP;
        Program advanced;
        Program extreme;
        Program loaded;
        Program Import()
        void ExecuteProgram();

    }

    class Player : GridObject
    {
        String image;
        CardinalDirection cardinalDirection;
    }

    class Field : IGridObject
    {
        IGridObject[,] Grid;
    }

    interface IGridObject{}
    class EmptySpace : IGridObject{}

    enum CardinalDirection
    {
        Nort,
        South, 
        East, 
        West
    }

    interface ICommand
    {
        String name;
        Field executeCommand(Field field){}
    }

    class RepeatCommand : ICommand {
    String name;
    Int times;
    List<ICommand> commands
    public Field executeCommand(Field field){}

    }

    class TurnCommand : ICommand {
        String name;
        Char turn;
        public Field executeCommand(Field field){}
    }

    class MoveCommand : ICommand {
        String name;
        Int steps;
        public Field executeCommand(Field field)
    }

}

