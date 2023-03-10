using Crew_Roster_DataAccessLayer;
using Crew_Roster_EntityAccesslayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crew_Roster_BusinessAccesslayer
{
    public class CrewRosterReportBL
    {

        CrewRosterReportDL DL;

        public CrewRosterReportBL()
        {
            DL = new CrewRosterReportDL();
        }


        #region Report

        public List<CrewRosterReport> Get_crewRosterReport(SearchCriteria search)
        {
            return DL.Get_crewRosterReport(search);
        }

        public List<CrewType> Get_CrewRank(SearchCriteria search)
        {
            return DL.Get_CrewRank(search);
        }

        public List<Employee> Get_employee(SearchCriteria search)
        {
            return DL.Get_employee(search);
        }

        public List<Employee> Get_Rank(SearchCriteria search)
        {
            return DL.Get_Rank(search);
        }

        public List<Base> Get_Base(SearchCriteria search)
        {
            return DL.Get_Base(search);
        }

        public List<Employee> Get_StaffList(SearchCriteria search)
        {
            return DL.Get_StaffList(search);
        }

        #endregion

        #region Dashboard

        public List<Employee> Get_StaffListForDD(SearchCriteria search)
        {
            return DL.Get_StaffListForDD(search);
        }

        public List<Employee> Get_EmployeeNameForDD(SearchCriteria search)
        {
            return DL.Get_EmployeeNameForDD(search);
        }

        public List<Employee> Get_RankListForDD(SearchCriteria search)
        {
            return DL.Get_RankListForDD(search);
        }

        public List<Base> Get_BaseListForDD(SearchCriteria search)
        {
            return DL.Get_BaseListForDD(search);
        }

        public List<Employee> Get_RosterListForDD(SearchCriteria search)
        {
            return DL.Get_RosterListForDD(search);
        }

        public List<Employee> Get_MonthListForDD(SearchCriteria search)
        {
            return DL.Get_MonthListForDD(search);
        }

        #region chart's 

        public List<Dashboardchart> Get_DashboardBaseWisePercentage(SearchCriteria search)
        {
            return DL.Get_DashboardBaseWisePercentage(search);
        }

        public List<Dashboardchart> DashboardRankWisePercentage(SearchCriteria search)
        {
            return DL.DashboardRankWisePercentage(search);
        }

        public List<Dashboardchart> DashboardStaffWisePercentage(SearchCriteria search)
        {
            return DL.DashboardStaffWisePercentage(search);
        }

        public List<Dashboardchart> Dashboard_one_StaffWisePercentage(SearchCriteria search)
        {
            return DL.Dashboard_one_StaffWisePercentage(search);
        }
        public List<Dashboardchart> DashboardOnload_one_StaffWisePercentage(SearchCriteria search)
        {
            return DL.DashboardOnload_one_StaffWisePercentage(search);
        }

        public List<Dashboardchart> Dashboard_all_StaffWisePercentage(SearchCriteria search)
        {
            return DL.Dashboard_all_StaffWisePercentage(search);
        }

        public List<Dashboardchart> DashboardCrewRankWisePercentage(SearchCriteria search)
        {
            return DL.DashboardCrewRankWisePercentage(search);
        }

        public List<Dashboardchart> DashboardonloadBaseandRankwisepercentage(SearchCriteria search)
        {
            return DL.DashboardonloadBaseandRankwisepercentage(search);
        }

        public List<Dashboardchart> DashboardBase_RankCrewwisepercentage(SearchCriteria search)
        {
            return DL.DashboardBase_RankCrewwisepercentage(search);
        }

        public List<Dashboardchart> DashboardSelectedCrewRankWisePercentage(SearchCriteria search)
        {
            return DL.DashboardSelectedCrewRankWisePercentage(search);
        }

        // roster wise
        public List<Dashboardchart> DashboardRosterWisePercentage(SearchCriteria search)
        {
            return DL.DashboardRosterWisePercentage(search);
        }

        public List<Dashboardchart> DashboardSelectedRosterWisePercentage(SearchCriteria search)
        {
            return DL.DashboardSelectedRosterWisePercentage(search);
        }

        // Onload wise
        public List<Dashboardchart> DashboardOnloadWisePercentage(SearchCriteria search)
        {
            return DL.DashboardOnloadWisePercentage(search);
        }

        public List<Dashboardchart> DashboardSelectedValueWisePercentage(SearchCriteria search)
        {
            return DL.DashboardSelectedValueWisePercentage(search);
        }

        // month wise
        public List<Dashboardchart> DashboardMonthWisePercentage(SearchCriteria search)
        {
            return DL.DashboardMonthWisePercentage(search);
        }

        public List<Dashboardchart> DashboardSelectedMonthWisePercentage(SearchCriteria search)
        {
            return DL.DashboardSelectedMonthWisePercentage(search);
        }

        #endregion


        #region grid

        public List<CrewRosterReport> Get_Grid_DashboardBaseWiseDataForGrid(SearchCriteria search)
        {
            return DL.Get_Grid_DashboardBaseWiseDataForGrid(search);
        }

        public List<CrewRosterReport> Get_Grid_sp_DashboardStaffWiseDataForGrid(SearchCriteria search)
        {
            return DL.Get_Grid_sp_DashboardStaffWiseDataForGrid(search);
        }
        public List<CrewRosterReport> Get_Grid_sp_DashboardStaffnDateWiseDataForGrid(SearchCriteria search)
        {
            return DL.Get_Grid_sp_DashboardStaffnDateWiseDataForGrid(search);
        }

        public List<CrewRosterReport> Get_Grid_sp_DashboardCrewRankWiseDataForGrid(SearchCriteria search)
        {
            return DL.Get_Grid_sp_DashboardCrewRankWiseDataForGrid(search);
        }

        
        public List<CrewRosterReport> Get_Grid_sp_DashboardOnloadWiseDataForGrid(SearchCriteria search)
        {
            return DL.Get_Grid_sp_DashboardOnloadWiseDataForGrid(search);
        }

        #endregion


        #endregion

    }
}
