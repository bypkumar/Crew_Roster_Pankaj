using Crew_Roster_BusinessAccesslayer;
using Crew_Roster_EntityAccesslayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crew_Roster.BusinessHelper
{
    public static class BusinessHelper
    {
        public static List<CrewRosterReport> Get_crewRosterReport(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_crewRosterReport(search);
        }

        public static List<CrewType> Get_CrewRank(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_CrewRank(search);
        }

        public static List<Employee> Get_employee(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_employee(search);
        }

        public static List<Employee> Get_Rank(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_Rank(search);
        }

        public static List<Base> Get_Base(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_Base(search);
        }

        public static List<Employee> Get_StaffList(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_StaffList(search);
        }

        #region Dashboard

        public static List<Employee> Get_StaffListForDD(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_StaffListForDD(search);
        }

        public static List<Employee> Get_EmployeeNameForDD(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_EmployeeNameForDD(search);
        }

        public static List<Employee> Get_RankListForDD(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_RankListForDD(search);
        }

        public static List<Base> Get_BaseListForDD(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_BaseListForDD(search);
        }

        public static List<Employee> Get_RosterListForDD(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_RosterListForDD(search);
        }

        public static List<Employee> Get_MonthListForDD(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_MonthListForDD(search);
        }


        #region chart's 
     
        public static List<Dashboardchart> Get_DashboardBaseWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_DashboardBaseWisePercentage(search);
        }



        public static List<Dashboardchart> DashboardRankWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.DashboardRankWisePercentage(search);
        }

        public static List<Dashboardchart> DashboardStaffWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.DashboardStaffWisePercentage(search);
        }

        // one staff
        public static List<Dashboardchart> Dashboard_one_StaffWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Dashboard_one_StaffWisePercentage(search);

        }
        // one staff for onload drilldown only
        public static List<Dashboardchart> DashboardOnload_one_StaffWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.DashboardOnload_one_StaffWisePercentage(search);

        }
        // all wise staff
        public static List<Dashboardchart> Dashboard_all_StaffWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Dashboard_all_StaffWisePercentage(search);


        }

        // Roster wise

        public static List<Dashboardchart> DashboardRosterWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.DashboardRosterWisePercentage(search);
        }

        public static List<Dashboardchart> DashboardSelectedRosterWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.DashboardSelectedRosterWisePercentage(search);
        }

        // Onload wise

        public static List<Dashboardchart> DashboardOnloadWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.DashboardOnloadWisePercentage(search);
        }

        public static List<Dashboardchart> DashboardSelectedValueWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.DashboardSelectedValueWisePercentage(search);
        }

        // Month wise

        public static List<Dashboardchart> DashboardMonthWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.DashboardMonthWisePercentage(search);
        }

        public static List<Dashboardchart> DashboardSelectedMonthWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.DashboardSelectedMonthWisePercentage(search);
        }

        public static List<Dashboardchart> DashboardCrewRankWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.DashboardCrewRankWisePercentage(search);
        }

        public static List<Dashboardchart> DashboardonloadBaseandRankwisepercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.DashboardonloadBaseandRankwisepercentage(search);
        }

        public static List<Dashboardchart> DashboardBase_RankCrewwisepercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.DashboardBase_RankCrewwisepercentage(search);
        }

        public static List<Dashboardchart> DashboardSelectedCrewRankWisePercentage(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.DashboardSelectedCrewRankWisePercentage(search);
        }

        #endregion

        #region grid
        public static List<CrewRosterReport> Get_Grid_DashboardBaseWiseDataForGrid(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_Grid_DashboardBaseWiseDataForGrid(search);
        }

        public static List<CrewRosterReport> Get_Grid_sp_DashboardStaffWiseDataForGrid(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_Grid_sp_DashboardStaffWiseDataForGrid(search);
        }
        public static List<CrewRosterReport> Get_Grid_sp_DashboardStaffnDateWiseDataForGrid(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_Grid_sp_DashboardStaffnDateWiseDataForGrid(search);
        }

        public static List<CrewRosterReport> Get_Grid_sp_DashboardCrewRankWiseDataForGrid(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_Grid_sp_DashboardCrewRankWiseDataForGrid(search);
        }
        
        public static List<CrewRosterReport> Get_Grid_sp_DashboardOnloadWiseDataForGrid(SearchCriteria search)
        {
            CrewRosterReportBL BL = new CrewRosterReportBL();
            return BL.Get_Grid_sp_DashboardOnloadWiseDataForGrid(search);
        }

        #endregion

        #endregion


    }
}