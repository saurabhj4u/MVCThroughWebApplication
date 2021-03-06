﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCThroughWebApplication.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBook(Book instance);
    partial void UpdateBook(Book instance);
    partial void DeleteBook(Book instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString, mappingSource)
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

        internal void SaveBook(int bId, string bName, string price)
        {
            throw new NotImplementedException();
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
		
		public System.Data.Linq.Table<Book> Books
		{
			get
			{
				return this.GetTable<Book>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.DeleteBook")]
		public int DeleteBook([global::System.Data.Linq.Mapping.ParameterAttribute(Name="BId", DbType="Int")] System.Nullable<int> bId, string bName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), bId);
			return ((int)(result.ReturnValue));
		}

        internal void UpdateBook(int bId, string bName, string price)
        {
            throw new NotImplementedException();
        }

        [global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAllBook")]
		public ISingleResult<GetAllBookResult> GetAllBook()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetAllBookResult>)(result.ReturnValue));
		}

        internal void DeleteBook(int id)
        {
            throw new NotImplementedException();
        }

        [global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SaveBook")]
		public int SaveBook([global::System.Data.Linq.Mapping.ParameterAttribute(Name="BId", DbType="Int")] System.Nullable<int> bId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="BName", DbType="VarChar(50)")] string bName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Price", DbType="Int")] System.Nullable<int> price)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), bId, bName, price);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.SearchBook")]
		public ISingleResult<SearchBookResult> SearchBook([global::System.Data.Linq.Mapping.ParameterAttribute(Name="BId", DbType="Int")] System.Nullable<int> bId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), bId);
			return ((ISingleResult<SearchBookResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.UpdateBook")]
		public int UpdateBook([global::System.Data.Linq.Mapping.ParameterAttribute(Name="BId", DbType="Int")] System.Nullable<int> bId, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="BName", DbType="VarChar(50)")] string bName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Price", DbType="Int")] System.Nullable<int> price)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), bId, bName, price);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Books")]
	public partial class Book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _BId;
		
		private string _BName;
		
		private string _Price;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBIdChanging(int value);
    partial void OnBIdChanged();
    partial void OnBNameChanging(string value);
    partial void OnBNameChanged();
    partial void OnPriceChanging(string value);
    partial void OnPriceChanged();
    #endregion
		
		public Book()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int BId
		{
			get
			{
				return this._BId;
			}
			set
			{
				if ((this._BId != value))
				{
					this.OnBIdChanging(value);
					this.SendPropertyChanging();
					this._BId = value;
					this.SendPropertyChanged("BId");
					this.OnBIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BName", DbType="NChar(10)")]
		public string BName
		{
			get
			{
				return this._BName;
			}
			set
			{
				if ((this._BName != value))
				{
					this.OnBNameChanging(value);
					this.SendPropertyChanging();
					this._BName = value;
					this.SendPropertyChanged("BName");
					this.OnBNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="NChar(10)")]
		public string Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
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
	
	public partial class GetAllBookResult
	{
		
		private int _BId;
		
		private string _BName;
		
		private string _Price;
		
		public GetAllBookResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BId", DbType="Int NOT NULL")]
		public int BId
		{
			get
			{
				return this._BId;
			}
			set
			{
				if ((this._BId != value))
				{
					this._BId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BName", DbType="NChar(10)")]
		public string BName
		{
			get
			{
				return this._BName;
			}
			set
			{
				if ((this._BName != value))
				{
					this._BName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="NChar(10)")]
		public string Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this._Price = value;
				}
			}
		}
	}
	
	public partial class SearchBookResult
	{
		
		private int _BId;
		
		private string _BName;
		
		private string _Price;
		
		public SearchBookResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BId", DbType="Int NOT NULL")]
		public int BId
		{
			get
			{
				return this._BId;
			}
			set
			{
				if ((this._BId != value))
				{
					this._BId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BName", DbType="NChar(10)")]
		public string BName
		{
			get
			{
				return this._BName;
			}
			set
			{
				if ((this._BName != value))
				{
					this._BName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="NChar(10)")]
		public string Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this._Price = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
