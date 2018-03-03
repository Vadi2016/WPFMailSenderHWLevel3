﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SendMail
{

    /// <summary>
    /// A basic command to run an Action
    /// </summary>
    public class RelayParamitarizedCommand : ICommand
    {

        #region Private Members

        /// <summary>
        /// The action to run
        /// </summary>
        private Action<object> mAction;

        #endregion

        #region Public Events

        /// <summary>
        /// The event thats fired when the <see cref="CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #endregion

        #region Constructor


        /// <summary>
        /// Default constructor
        /// </summary>
        public RelayParamitarizedCommand(Action<object> action)
        {
            mAction = action;
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// A relay command can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Execute the commands Action
        /// </summary>
        /// <param` name="parameter"></param>
        public void Execute(object parameter)
        {
            mAction(parameter);
        }

        #endregion
    }
}
