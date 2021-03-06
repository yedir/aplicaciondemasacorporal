﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControldeMasaMuscular.Movil
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
	
	
	public partial class BaseDatosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertPerfil(Perfil instance);
    partial void UpdatePerfil(Perfil instance);
    partial void DeletePerfil(Perfil instance);
    partial void InsertRegistros(Registros instance);
    partial void UpdateRegistros(Registros instance);
    partial void DeleteRegistros(Registros instance);
    #endregion
		
		public BaseDatosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BaseDatosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BaseDatosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BaseDatosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Perfil> Perfil
		{
			get
			{
				return this.GetTable<Perfil>();
			}
		}
		
		public System.Data.Linq.Table<Registros> Registros
		{
			get
			{
				return this.GetTable<Registros>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Perfil : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Nombre;
		
		private int _Peso;
		
		private EntityRef<Registros> _Registros;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnPesoChanging(int value);
    partial void OnPesoChanged();
    #endregion
		
		public Perfil()
		{
			this._Registros = default(EntityRef<Registros>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Peso", IsPrimaryKey=true)]
		public int Peso
		{
			get
			{
				return this._Peso;
			}
			set
			{
				if ((this._Peso != value))
				{
					if (this._Registros.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPesoChanging(value);
					this.SendPropertyChanging();
					this._Peso = value;
					this.SendPropertyChanged("Peso");
					this.OnPesoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Registros_Perfil", Storage="_Registros", ThisKey="Peso", OtherKey="Peso", IsForeignKey=true)]
		public Registros Registros
		{
			get
			{
				return this._Registros.Entity;
			}
			set
			{
				Registros previousValue = this._Registros.Entity;
				if (((previousValue != value) 
							|| (this._Registros.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Registros.Entity = null;
						previousValue.Perfil.Remove(this);
					}
					this._Registros.Entity = value;
					if ((value != null))
					{
						value.Perfil.Add(this);
						this._Peso = value.Peso;
					}
					else
					{
						this._Peso = default(int);
					}
					this.SendPropertyChanged("Registros");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="")]
	public partial class Registros : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Nombre;
		
		private string _Obeso;
		
		private string _Delgado;
		
		private string _Troso;
		
		private int _Peso;
		
		private EntitySet<Perfil> _Perfil;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnObesoChanging(string value);
    partial void OnObesoChanged();
    partial void OnDelgadoChanging(string value);
    partial void OnDelgadoChanged();
    partial void OnTrosoChanging(string value);
    partial void OnTrosoChanged();
    partial void OnPesoChanging(int value);
    partial void OnPesoChanged();
    #endregion
		
		public Registros()
		{
			this._Perfil = new EntitySet<Perfil>(new Action<Perfil>(this.attach_Perfil), new Action<Perfil>(this.detach_Perfil));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", CanBeNull=false)]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Obeso", CanBeNull=false)]
		public string Obeso
		{
			get
			{
				return this._Obeso;
			}
			set
			{
				if ((this._Obeso != value))
				{
					this.OnObesoChanging(value);
					this.SendPropertyChanging();
					this._Obeso = value;
					this.SendPropertyChanged("Obeso");
					this.OnObesoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Delgado", CanBeNull=false)]
		public string Delgado
		{
			get
			{
				return this._Delgado;
			}
			set
			{
				if ((this._Delgado != value))
				{
					this.OnDelgadoChanging(value);
					this.SendPropertyChanging();
					this._Delgado = value;
					this.SendPropertyChanged("Delgado");
					this.OnDelgadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Troso", CanBeNull=false)]
		public string Troso
		{
			get
			{
				return this._Troso;
			}
			set
			{
				if ((this._Troso != value))
				{
					this.OnTrosoChanging(value);
					this.SendPropertyChanging();
					this._Troso = value;
					this.SendPropertyChanged("Troso");
					this.OnTrosoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Peso", IsPrimaryKey=true)]
		public int Peso
		{
			get
			{
				return this._Peso;
			}
			set
			{
				if ((this._Peso != value))
				{
					this.OnPesoChanging(value);
					this.SendPropertyChanging();
					this._Peso = value;
					this.SendPropertyChanged("Peso");
					this.OnPesoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Registros_Perfil", Storage="_Perfil", ThisKey="Peso", OtherKey="Peso")]
		public EntitySet<Perfil> Perfil
		{
			get
			{
				return this._Perfil;
			}
			set
			{
				this._Perfil.Assign(value);
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
		
		private void attach_Perfil(Perfil entity)
		{
			this.SendPropertyChanging();
			entity.Registros = this;
		}
		
		private void detach_Perfil(Perfil entity)
		{
			this.SendPropertyChanging();
			entity.Registros = null;
		}
	}
}
#pragma warning restore 1591
