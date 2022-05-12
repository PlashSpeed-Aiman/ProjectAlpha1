using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using ReactiveUI;

namespace ProjectAlpha1.ViewModel
{
    internal class MainViewModel:ViewModelBase
    {
        private string _invoiceNumber;
        private DateTime _issueTime = DateTime.Today;

        public MainViewModel()
        {
            _issueTime = new DateTime().Date;
        }
        public DateTime IssueTime
        {
            get { return _issueTime;}
            set
            {
                IssueTime = value.Date;
                this.RaisePropertyChanged("IssueTime");
            }
        }

        public void Generate()
        {
           
        }
    }
}
