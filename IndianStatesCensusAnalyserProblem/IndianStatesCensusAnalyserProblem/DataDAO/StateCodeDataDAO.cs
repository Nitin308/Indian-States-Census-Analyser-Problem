using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyserProblem.DataDAO
{
    public class StateCodeDataDAO
    {
        public int serialNumber;
        public string stateName;
        public int tin;
        public string stateCode;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="serialNumber"></param>
        /// <param name="stateName"></param>
        /// <param name="tin"></param>
        /// <param name="stateCode"></param>
        public StateCodeDataDAO(string serialNumber, string stateName, string tin, string stateCode)
        {
            this.serialNumber = Convert.ToInt32(serialNumber);
            this.stateName = stateName;
            this.tin = Convert.ToInt32(tin);
            this.stateCode = stateCode;
        }
    }
}