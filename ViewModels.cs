using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMVVM
{
    public class ViewModels : NotificationObject
    {
        #region Properties

        private double input1;
        public double Input1
        {
            get => input1;
            set
            {
                this.input1 = value;
                this.RaisePropertyChangted("Input1");
            }
        }

        private double input2;
        public double Input2
        {
            get => input2;
            set
            {
                this.input2 = value;
                this.RaisePropertyChangted("Input2");
            }
        }

        private double result;
        public double Result
        {
            get => result;
            set
            {
                result = value;
                RaisePropertyChangted("Result");
            }
        }

        #endregion

        #region Commands

        public Commands AddCommand { get; set; }
        private void Add(object parameter)
        {
            Result = Input1 + Input2;
        }

        public ViewModels()
        {
            this.AddCommand = new Commands();
            this.AddCommand.ExcuteAction = new Action<object>(this.Add);
        }

        #endregion
    }
}
