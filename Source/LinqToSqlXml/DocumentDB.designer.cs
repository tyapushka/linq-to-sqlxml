﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToSqlXml
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DocumentDB")]
	internal partial class DocumentDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDocument(Document instance);
    partial void UpdateDocument(Document instance);
    partial void DeleteDocument(Document instance);
    #endregion
		
		public DocumentDataContext() : 
				base(global::LinqToSqlXml.Properties.Settings.Default.LinqToSqlXmlConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DocumentDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DocumentDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DocumentDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DocumentDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Document> Documents
		{
			get
			{
				return this.GetTable<Document>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Documents")]
	public partial class Document : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _Id;
		
		private string _DbName;
		
		private string _CollectionName;
		
		private System.Xml.Linq.XElement _DocumentData;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(System.Guid value);
    partial void OnIdChanged();
    partial void OnDbNameChanging(string value);
    partial void OnDbNameChanged();
    partial void OnCollectionNameChanging(string value);
    partial void OnCollectionNameChanged();
    partial void OnDocumentDataChanging(System.Xml.Linq.XElement value);
    partial void OnDocumentDataChanged();
    #endregion
		
		public Document()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid Id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DbName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DbName
		{
			get
			{
				return this._DbName;
			}
			set
			{
				if ((this._DbName != value))
				{
					this.OnDbNameChanging(value);
					this.SendPropertyChanging();
					this._DbName = value;
					this.SendPropertyChanged("DbName");
					this.OnDbNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CollectionName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CollectionName
		{
			get
			{
				return this._CollectionName;
			}
			set
			{
				if ((this._CollectionName != value))
				{
					this.OnCollectionNameChanging(value);
					this.SendPropertyChanging();
					this._CollectionName = value;
					this.SendPropertyChanged("CollectionName");
					this.OnCollectionNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DocumentData", DbType="Xml NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Xml.Linq.XElement DocumentData
		{
			get
			{
				return this._DocumentData;
			}
			set
			{
				if ((this._DocumentData != value))
				{
					this.OnDocumentDataChanging(value);
					this.SendPropertyChanging();
					this._DocumentData = value;
					this.SendPropertyChanged("DocumentData");
					this.OnDocumentDataChanged();
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