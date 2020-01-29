﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Resgrid.ApiClient.V3.Models
{
	public class Call
	{
		public int CallId { get; set; }
		public string Number { get; set; }
		public int DepartmentId { get; set; }
		public string ReportingUserId { get; set; }
		public int Priority { get; set; }
		public bool IsCritical { get; set; }
		public string Type { get; set; }
		public string IncidentNumber { get; set; }
		public string Name { get; set; }
		public string NatureOfCall { get; set; }
		public string MapPage { get; set; }
		public string Notes { get; set; }
		public string CompletedNotes { get; set; }
		public string Address { get; set; }
		public string GeoLocationData { get; set; }
		public DateTime LoggedOn { get; set; }
		public string ClosedByUserId { get; set; }
		public DateTime? ClosedOn { get; set; }
		public int State { get; set; }
		public bool IsDeleted { get; set; }
		public int CallSource { get; set; }
		public int DispatchCount { get; set; }
		public DateTime? LastDispatchedOn { get; set; }
		public string SourceIdentifier { get; set; }
		public ICollection<CallDispatch> Dispatches { get; set; }
		public ICollection<CallAttachment> Attachments { get; set; }
		//public ICollection<CallNote> CallNotes { get; set; }
		public string W3W { get; set; }
		public ICollection<CallDispatchGroup> GroupDispatches { get; set; }
		public ICollection<CallDispatchUnit> UnitDispatches { get; set; }
		public ICollection<CallDispatchRole> RoleDispatches { get; set; }
		public string ContactName { get; set; }
		public string ContactNumber { get; set; }
		public bool Public { get; set; }
		public string ExternalIdentifier { get; set; }
		public string ReferenceNumber { get; set; }
		public List<string> GroupCodesToDispatch { get; set; }
		public bool AllCall { get; set; }
	}
}
