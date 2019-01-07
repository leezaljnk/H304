using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Winforms.UserControls.ValidateForm
{
    public class StepResult
    {
        public string Summary {get;set;}
        public string Detail {get;set;}
    }
    public class EventStep
    {
        public int StepNo { get; set; }
        public string StepTitle { get; set; }
        public StepResult Result { get; set; }
        public bool StepError { get; set; }

        public delegate StepResult OnProcess();
        public OnProcess _OnProcess;
    }
}
