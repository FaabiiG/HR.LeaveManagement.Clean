﻿using HR.LeaveManagement.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR.LeaveManagement.Domain;

public class LeaveRequest : BaseEntity
{
   

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public LeaveType? LeaveType { get; set; }

    public int LeaveTypeId { get; set; }

    public DateTime DateRequest { get; set;}

    public string? RequestsComments { get; set; }

    public bool? Approved { get; set; }

    public bool? Cancelled { get; set; }

    public string? RequestingEmployeeId { get; set; }

}