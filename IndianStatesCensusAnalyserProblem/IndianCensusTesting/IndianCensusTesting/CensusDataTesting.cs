using Microsoft.VisualStudio.TestTools.UnitTesting;
using IndianStatesCensusAnalyserProblem;
using System;
using System.Collections.Generic;
using IndianStatesCensusAnalyserProblem.DTO;

namespace IndianCensusTesting
{
    [TestClass]
    public class CensusDataTesting
    {
        CSVAdapterFactory adapter;
        public Dictionary<string, CensusDTO> stateRecords;

        [TestInitialize]
        public void SetUp()
        {
            adapter = new CSVAdapterFactory();
            stateRecords = new Dictionary<string, CensusDTO>();
        }
        /// <summary>
        /// TC 1.1 - Check to ensure the Number of Record matches
        /// </summary>
        [TestMethod]
        public void GivenStateCensusCSVShouldReturnsRecords()
        {
            string path = @"C:\Users\DELL\source\repos\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSVFiles\IndianPopulation.csv";
            stateRecords = adapter.LoadCsvData(CensusAnalyser.Country.INDIA, path, "State,Population,AreaInSqKm,DensityPerSqKm");
            Assert.AreEqual(29, stateRecords.Count);
        }
        /// <summary>
        /// TC 1.2 - Given the State Census CSV File if incorrect path Returns a custom Exception
        /// </summary>
        [TestMethod]
        public void GivenWrongFilePathReturnsCustomException()
        {
            string path = @"C:\Users\DELL\source\repos\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSVFiles\Indian.csv";
            string excepted = "File Not Found";
            try
            {
                stateRecords = adapter.LoadCsvData(CensusAnalyser.Country.INDIA, path, "State,Population,AreaInSqKm,DensityPerSqKm");
                Assert.AreEqual(29, stateRecords.Count);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(excepted, ex.Message);
            }
        }
        /// <summary>
        /// TC 1.3 - Given the State Census CSV File if incorrect file type Returns a custom Exception
        /// </summary>
        [TestMethod]
        public void GivenWrongFileTypeReturnsCustomException()
        {
            string path = @"C:\Users\DELL\source\repos\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSVFiles\IndianPopulation.txt";
            string excepted = "Invalid file type";
            try
            {
                stateRecords = adapter.LoadCsvData(CensusAnalyser.Country.INDIA, path, "State,Population,AreaInSqKm,DensityPerSqKm");
                Assert.AreEqual(29, stateRecords.Count);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(excepted, ex.Message);
            }
        }
        /// <summary>
        /// TC 1.4 - Given the state Census CSV File when correct but delimiter incorrect returns a custom exception
        /// </summary>
        [TestMethod]
        public void GivenWrongDelimiterReturnsCustomException()
        {
            string path = @"C:\Users\DELL\source\repos\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSVFiles\DelimiterIndiaStateCensusData.csv";
            string excepted = "File Containers Wrong Delimiter";
            try
            {
                stateRecords = adapter.LoadCsvData(CensusAnalyser.Country.INDIA, path, "State,Population,AreaInSqKm,DensityPerSqKm");
                Assert.AreEqual(29, stateRecords.Count);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(excepted, ex.Message);
            }
        }
        /// <summary>
        /// TC 1.5 - Given the state Census CSV File when correct but incorrect dataheader returns a custom exception
        /// </summary>
        [TestMethod]
        public void GivenWrongDataHeaderReturnsCustomException()
        {
            string path = @"C:\Users\DELL\source\repos\IndianStatesCensusAnalyserProblem\IndianStatesCensusAnalyserProblem\CSVFiles\WrongIndiaStateCensusData.csv";
            string excepted = "Incorrect header in Data";
            try
            {
                stateRecords = adapter.LoadCsvData(CensusAnalyser.Country.INDIA, path, "State,Population,AreaInSqKm,DensityPerSqKm");
                Assert.AreEqual(29, stateRecords.Count);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(excepted, ex.Message);
            }
        }
    }
}