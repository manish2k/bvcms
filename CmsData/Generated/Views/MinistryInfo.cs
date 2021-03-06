using System; 
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Linq.Expressions;
using System.ComponentModel;

namespace CmsData.View
{
	[Table(Name="MinistryInfo")]
	public partial class MinistryInfo
	{
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		
		private int _PeopleId;
		
		private int? _LastContactReceivedId;
		
		private DateTime? _LastContactReceivedDt;
		
		private int? _LastContactMadeId;
		
		private DateTime? _LastContactMadeDt;
		
		private int? _TaskAboutId;
		
		private DateTime? _TaskAboutDt;
		
		private int? _TaskDelegatedId;
		
		private DateTime? _TaskDelegatedDt;
		
		
		public MinistryInfo()
		{
		}

		
		
		[Column(Name="PeopleId", Storage="_PeopleId", DbType="int NOT NULL")]
		public int PeopleId
		{
			get
			{
				return this._PeopleId;
			}

			set
			{
				if (this._PeopleId != value)
					this._PeopleId = value;
			}

		}

		
		[Column(Name="LastContactReceivedId", Storage="_LastContactReceivedId", DbType="int")]
		public int? LastContactReceivedId
		{
			get
			{
				return this._LastContactReceivedId;
			}

			set
			{
				if (this._LastContactReceivedId != value)
					this._LastContactReceivedId = value;
			}

		}

		
		[Column(Name="LastContactReceivedDt", Storage="_LastContactReceivedDt", DbType="datetime")]
		public DateTime? LastContactReceivedDt
		{
			get
			{
				return this._LastContactReceivedDt;
			}

			set
			{
				if (this._LastContactReceivedDt != value)
					this._LastContactReceivedDt = value;
			}

		}

		
		[Column(Name="LastContactMadeId", Storage="_LastContactMadeId", DbType="int")]
		public int? LastContactMadeId
		{
			get
			{
				return this._LastContactMadeId;
			}

			set
			{
				if (this._LastContactMadeId != value)
					this._LastContactMadeId = value;
			}

		}

		
		[Column(Name="LastContactMadeDt", Storage="_LastContactMadeDt", DbType="datetime")]
		public DateTime? LastContactMadeDt
		{
			get
			{
				return this._LastContactMadeDt;
			}

			set
			{
				if (this._LastContactMadeDt != value)
					this._LastContactMadeDt = value;
			}

		}

		
		[Column(Name="TaskAboutId", Storage="_TaskAboutId", DbType="int")]
		public int? TaskAboutId
		{
			get
			{
				return this._TaskAboutId;
			}

			set
			{
				if (this._TaskAboutId != value)
					this._TaskAboutId = value;
			}

		}

		
		[Column(Name="TaskAboutDt", Storage="_TaskAboutDt", DbType="datetime")]
		public DateTime? TaskAboutDt
		{
			get
			{
				return this._TaskAboutDt;
			}

			set
			{
				if (this._TaskAboutDt != value)
					this._TaskAboutDt = value;
			}

		}

		
		[Column(Name="TaskDelegatedId", Storage="_TaskDelegatedId", DbType="int")]
		public int? TaskDelegatedId
		{
			get
			{
				return this._TaskDelegatedId;
			}

			set
			{
				if (this._TaskDelegatedId != value)
					this._TaskDelegatedId = value;
			}

		}

		
		[Column(Name="TaskDelegatedDt", Storage="_TaskDelegatedDt", DbType="datetime")]
		public DateTime? TaskDelegatedDt
		{
			get
			{
				return this._TaskDelegatedDt;
			}

			set
			{
				if (this._TaskDelegatedDt != value)
					this._TaskDelegatedDt = value;
			}

		}

		
    }

}
