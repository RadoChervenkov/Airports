#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;

namespace Airports.Models.MySql	
{
	public partial class Jsonreport
	{
		private int _reportId;
		public virtual int ReportId
		{
			get
			{
				return this._reportId;
			}
			set
			{
				this._reportId = value;
			}
		}
		
		private int? _flightId;
		public virtual int? FlightId
		{
			get
			{
				return this._flightId;
			}
			set
			{
				this._flightId = value;
			}
		}
		
		private int? _departureAirportId;
		public virtual int? DepartureAirportId
		{
			get
			{
				return this._departureAirportId;
			}
			set
			{
				this._departureAirportId = value;
			}
		}
		
		private int? _arrivalAirportId;
		public virtual int? ArrivalAirportId
		{
			get
			{
				return this._arrivalAirportId;
			}
			set
			{
				this._arrivalAirportId = value;
			}
		}
		
		private string _flightCode;
		public virtual string FlightCode
		{
			get
			{
				return this._flightCode;
			}
			set
			{
				this._flightCode = value;
			}
		}
		
		private DateTime? _flightDate;
		public virtual DateTime? FlightDate
		{
			get
			{
				return this._flightDate;
			}
			set
			{
				this._flightDate = value;
			}
		}
		
		private float? _durationHours;
		public virtual float? DurationHours
		{
			get
			{
				return this._durationHours;
			}
			set
			{
				this._durationHours = value;
			}
		}
		
		private string _airlineId;
		public virtual string AirlineId
		{
			get
			{
				return this._airlineId;
			}
			set
			{
				this._airlineId = value;
			}
		}
		
	}
}
#pragma warning restore 1591
