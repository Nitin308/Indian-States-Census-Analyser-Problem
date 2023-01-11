using IndianStatesCensusAnalyserProblem.DataDAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStatesCensusAnalyserProblem.DTO
{
    public class CensusDTO
    {
        public int serialNumber;
        public string stateName;
        public string state;
        public int tin;
        public string stateCode;
        public long population;
        public long area;
        public long density;
        public double totalArea;
        public double waterArea;
        public double landArea;
        /// <summary>
        /// creating a Constructor for Statecodedata
        /// </summary>
        /// <param name="stateCodeDataDAO"></param>
        public CensusDTO(StateCodeDataDAO stateCodeDataDAO)
        {
            this.serialNumber = stateCodeDataDAO.serialNumber;
            this.stateName = stateCodeDataDAO.stateName;
            this.tin = stateCodeDataDAO.tin;
            this.stateCode = stateCodeDataDAO.stateCode;
        }
        /// <summary>
        /// creating constructor for Populationdata
        /// </summary>
        /// <param name="censusDataDAO"></param>
        public CensusDTO(PopulationDataDAO censusDataDAO)
        {
            this.state = censusDataDAO.state;
            this.population = censusDataDAO.population;
            this.area = censusDataDAO.area;
            this.density = censusDataDAO.density;
        }

    }
}