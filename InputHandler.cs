using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MazeCrawler
{
    internal class InputHandler
    {
        private Dictionary<char, ICommand> commands;

        public InputHandler()
        {
            this.commands = new Dictionary<char, ICommand>
            {
                { 'w', new MoveUpCommand() },
                { 'a', new MoveLeftCommand() },
                { 's', new MoveDownCommand() },
                { 'd', new MoveRightCommand() }
            }; ;
        }

        public ICommand? HandleInput(char input)
        {
            if (commands.TryGetValue(input, out ICommand command))
                return command;
            return null;
        }
    }
}
