using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyMVVM
{
    public class Commands : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public Action<object> ExcuteAction { get; set; }
        public Func<object,bool> CanExecuteFunc { get; set; }

        public bool CanExecute(object parameter)
        {
            if (this.CanExecuteFunc == null)
            {
                return true;
            }
            else
                return this.CanExecuteFunc.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            if(ExcuteAction != null)
            {
                this.ExcuteAction.Invoke(parameter);
            }
        }
    }
}
