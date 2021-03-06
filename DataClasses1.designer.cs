﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HouseofPain
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HOP-db")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMship(Mship instance);
    partial void UpdateMship(Mship instance);
    partial void DeleteMship(Mship instance);
    partial void InsertMdetail(Mdetail instance);
    partial void UpdateMdetail(Mdetail instance);
    partial void DeleteMdetail(Mdetail instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::HouseofPain.Properties.Settings.Default.HOP_dbConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Mship> Mships
		{
			get
			{
				return this.GetTable<Mship>();
			}
		}
		
		public System.Data.Linq.Table<Mdetail> Mdetails
		{
			get
			{
				return this.GetTable<Mdetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mship")]
	public partial class Mship : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _pg;
		
		private string _programme;
		
		private string _sdate;
		
		private string _price;
		
		private string _sfee;
		
		private string _nvisits;
		
		private string _conditions;
		
		private string _IDD;
		
		private string _edate;
		
		private string _medate;
		
		private string _state;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnpgChanging(string value);
    partial void OnpgChanged();
    partial void OnprogrammeChanging(string value);
    partial void OnprogrammeChanged();
    partial void OnsdateChanging(string value);
    partial void OnsdateChanged();
    partial void OnpriceChanging(string value);
    partial void OnpriceChanged();
    partial void OnsfeeChanging(string value);
    partial void OnsfeeChanged();
    partial void OnnvisitsChanging(string value);
    partial void OnnvisitsChanged();
    partial void OnconditionsChanging(string value);
    partial void OnconditionsChanged();
    partial void OnIDDChanging(string value);
    partial void OnIDDChanged();
    partial void OnedateChanging(string value);
    partial void OnedateChanged();
    partial void OnmedateChanging(string value);
    partial void OnmedateChanged();
    partial void OnstateChanging(string value);
    partial void OnstateChanged();
    #endregion
		
		public Mship()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pg", DbType="NVarChar(50)")]
		public string pg
		{
			get
			{
				return this._pg;
			}
			set
			{
				if ((this._pg != value))
				{
					this.OnpgChanging(value);
					this.SendPropertyChanging();
					this._pg = value;
					this.SendPropertyChanged("pg");
					this.OnpgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_programme", DbType="NVarChar(50)")]
		public string programme
		{
			get
			{
				return this._programme;
			}
			set
			{
				if ((this._programme != value))
				{
					this.OnprogrammeChanging(value);
					this.SendPropertyChanging();
					this._programme = value;
					this.SendPropertyChanged("programme");
					this.OnprogrammeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sdate", DbType="NVarChar(50)")]
		public string sdate
		{
			get
			{
				return this._sdate;
			}
			set
			{
				if ((this._sdate != value))
				{
					this.OnsdateChanging(value);
					this.SendPropertyChanging();
					this._sdate = value;
					this.SendPropertyChanged("sdate");
					this.OnsdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_price", DbType="NVarChar(50)")]
		public string price
		{
			get
			{
				return this._price;
			}
			set
			{
				if ((this._price != value))
				{
					this.OnpriceChanging(value);
					this.SendPropertyChanging();
					this._price = value;
					this.SendPropertyChanged("price");
					this.OnpriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sfee", DbType="NVarChar(50)")]
		public string sfee
		{
			get
			{
				return this._sfee;
			}
			set
			{
				if ((this._sfee != value))
				{
					this.OnsfeeChanging(value);
					this.SendPropertyChanging();
					this._sfee = value;
					this.SendPropertyChanged("sfee");
					this.OnsfeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nvisits", DbType="NVarChar(50)")]
		public string nvisits
		{
			get
			{
				return this._nvisits;
			}
			set
			{
				if ((this._nvisits != value))
				{
					this.OnnvisitsChanging(value);
					this.SendPropertyChanging();
					this._nvisits = value;
					this.SendPropertyChanged("nvisits");
					this.OnnvisitsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_conditions", DbType="NVarChar(100)")]
		public string conditions
		{
			get
			{
				return this._conditions;
			}
			set
			{
				if ((this._conditions != value))
				{
					this.OnconditionsChanging(value);
					this.SendPropertyChanging();
					this._conditions = value;
					this.SendPropertyChanged("conditions");
					this.OnconditionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDD", DbType="NVarChar(50)")]
		public string IDD
		{
			get
			{
				return this._IDD;
			}
			set
			{
				if ((this._IDD != value))
				{
					this.OnIDDChanging(value);
					this.SendPropertyChanging();
					this._IDD = value;
					this.SendPropertyChanged("IDD");
					this.OnIDDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_edate", DbType="NVarChar(50)")]
		public string edate
		{
			get
			{
				return this._edate;
			}
			set
			{
				if ((this._edate != value))
				{
					this.OnedateChanging(value);
					this.SendPropertyChanging();
					this._edate = value;
					this.SendPropertyChanged("edate");
					this.OnedateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_medate", DbType="NVarChar(50)")]
		public string medate
		{
			get
			{
				return this._medate;
			}
			set
			{
				if ((this._medate != value))
				{
					this.OnmedateChanging(value);
					this.SendPropertyChanging();
					this._medate = value;
					this.SendPropertyChanged("medate");
					this.OnmedateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_state", DbType="NVarChar(50)")]
		public string state
		{
			get
			{
				return this._state;
			}
			set
			{
				if ((this._state != value))
				{
					this.OnstateChanging(value);
					this.SendPropertyChanging();
					this._state = value;
					this.SendPropertyChanged("state");
					this.OnstateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Mdetail")]
	public partial class Mdetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _fname;
		
		private string _lname;
		
		private string _gender;
		
		private string _street;
		
		private string _city;
		
		private string _home;
		
		private string _cell;
		
		private string _cardn;
		
		private string _workp;
		
		private string _occu;
		
		private string _org;
		
		private string _invtype;
		
		private string _ptrain;
		
		private string _email;
		
		private System.Data.Linq.Binary _dp;
		
		private string _IDD;
		
		private string _photo;
		
		private string _dop;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnfnameChanging(string value);
    partial void OnfnameChanged();
    partial void OnlnameChanging(string value);
    partial void OnlnameChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OnstreetChanging(string value);
    partial void OnstreetChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void OnhomeChanging(string value);
    partial void OnhomeChanged();
    partial void OncellChanging(string value);
    partial void OncellChanged();
    partial void OncardnChanging(string value);
    partial void OncardnChanged();
    partial void OnworkpChanging(string value);
    partial void OnworkpChanged();
    partial void OnoccuChanging(string value);
    partial void OnoccuChanged();
    partial void OnorgChanging(string value);
    partial void OnorgChanged();
    partial void OninvtypeChanging(string value);
    partial void OninvtypeChanged();
    partial void OnptrainChanging(string value);
    partial void OnptrainChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OndpChanging(System.Data.Linq.Binary value);
    partial void OndpChanged();
    partial void OnIDDChanging(string value);
    partial void OnIDDChanged();
    partial void OnphotoChanging(string value);
    partial void OnphotoChanged();
    partial void OndopChanging(string value);
    partial void OndopChanged();
    #endregion
		
		public Mdetail()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="NChar(50)")]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this.OnfnameChanging(value);
					this.SendPropertyChanging();
					this._fname = value;
					this.SendPropertyChanged("fname");
					this.OnfnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="NChar(50)")]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this.OnlnameChanging(value);
					this.SendPropertyChanging();
					this._lname = value;
					this.SendPropertyChanged("lname");
					this.OnlnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="NChar(50)")]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_street", DbType="NChar(50)")]
		public string street
		{
			get
			{
				return this._street;
			}
			set
			{
				if ((this._street != value))
				{
					this.OnstreetChanging(value);
					this.SendPropertyChanging();
					this._street = value;
					this.SendPropertyChanged("street");
					this.OnstreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="NChar(50)")]
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_home", DbType="NChar(50)")]
		public string home
		{
			get
			{
				return this._home;
			}
			set
			{
				if ((this._home != value))
				{
					this.OnhomeChanging(value);
					this.SendPropertyChanging();
					this._home = value;
					this.SendPropertyChanged("home");
					this.OnhomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cell", DbType="NChar(50)")]
		public string cell
		{
			get
			{
				return this._cell;
			}
			set
			{
				if ((this._cell != value))
				{
					this.OncellChanging(value);
					this.SendPropertyChanging();
					this._cell = value;
					this.SendPropertyChanged("cell");
					this.OncellChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cardn", DbType="NChar(50)")]
		public string cardn
		{
			get
			{
				return this._cardn;
			}
			set
			{
				if ((this._cardn != value))
				{
					this.OncardnChanging(value);
					this.SendPropertyChanging();
					this._cardn = value;
					this.SendPropertyChanged("cardn");
					this.OncardnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_workp", DbType="NChar(50)")]
		public string workp
		{
			get
			{
				return this._workp;
			}
			set
			{
				if ((this._workp != value))
				{
					this.OnworkpChanging(value);
					this.SendPropertyChanging();
					this._workp = value;
					this.SendPropertyChanged("workp");
					this.OnworkpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_occu", DbType="NChar(50)")]
		public string occu
		{
			get
			{
				return this._occu;
			}
			set
			{
				if ((this._occu != value))
				{
					this.OnoccuChanging(value);
					this.SendPropertyChanging();
					this._occu = value;
					this.SendPropertyChanged("occu");
					this.OnoccuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_org", DbType="NChar(50)")]
		public string org
		{
			get
			{
				return this._org;
			}
			set
			{
				if ((this._org != value))
				{
					this.OnorgChanging(value);
					this.SendPropertyChanging();
					this._org = value;
					this.SendPropertyChanged("org");
					this.OnorgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_invtype", DbType="NChar(50)")]
		public string invtype
		{
			get
			{
				return this._invtype;
			}
			set
			{
				if ((this._invtype != value))
				{
					this.OninvtypeChanging(value);
					this.SendPropertyChanging();
					this._invtype = value;
					this.SendPropertyChanged("invtype");
					this.OninvtypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ptrain", DbType="NChar(50)")]
		public string ptrain
		{
			get
			{
				return this._ptrain;
			}
			set
			{
				if ((this._ptrain != value))
				{
					this.OnptrainChanging(value);
					this.SendPropertyChanging();
					this._ptrain = value;
					this.SendPropertyChanged("ptrain");
					this.OnptrainChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NChar(50)")]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dp", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary dp
		{
			get
			{
				return this._dp;
			}
			set
			{
				if ((this._dp != value))
				{
					this.OndpChanging(value);
					this.SendPropertyChanging();
					this._dp = value;
					this.SendPropertyChanged("dp");
					this.OndpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDD", DbType="NChar(50)")]
		public string IDD
		{
			get
			{
				return this._IDD;
			}
			set
			{
				if ((this._IDD != value))
				{
					this.OnIDDChanging(value);
					this.SendPropertyChanging();
					this._IDD = value;
					this.SendPropertyChanged("IDD");
					this.OnIDDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_photo", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string photo
		{
			get
			{
				return this._photo;
			}
			set
			{
				if ((this._photo != value))
				{
					this.OnphotoChanging(value);
					this.SendPropertyChanging();
					this._photo = value;
					this.SendPropertyChanged("photo");
					this.OnphotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dop", DbType="NChar(50)")]
		public string dop
		{
			get
			{
				return this._dop;
			}
			set
			{
				if ((this._dop != value))
				{
					this.OndopChanging(value);
					this.SendPropertyChanging();
					this._dop = value;
					this.SendPropertyChanged("dop");
					this.OndopChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
