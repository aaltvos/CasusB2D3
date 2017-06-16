using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechnoBackend.Business_Logic.ValidateReview
{
    public class WorkItem
    {
        private readonly string _description;

        private State _state;

        public WorkItem(string description)
        {
            _description = description;
        }

        public String GetDescription() { return _description; }
        public State GetState() { return _state; }
        public void SetState(State state) { _state = state;  }

        public enum State
        {
            Accepted, Denied, Unknown
        }

    }
}