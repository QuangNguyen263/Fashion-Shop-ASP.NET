﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ProjectFinal")]
public partial class LQDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void Insertcart(cart instance);
  partial void Updatecart(cart instance);
  partial void Deletecart(cart instance);
  partial void Insertcat(cat instance);
  partial void Updatecat(cat instance);
  partial void Deletecat(cat instance);
  partial void Insertcust(cust instance);
  partial void Updatecust(cust instance);
  partial void Deletecust(cust instance);
  partial void Insertimg_prod(img_prod instance);
  partial void Updateimg_prod(img_prod instance);
  partial void Deleteimg_prod(img_prod instance);
  partial void Insertprod(prod instance);
  partial void Updateprod(prod instance);
  partial void Deleteprod(prod instance);
  partial void Insertrole(role instance);
  partial void Updaterole(role instance);
  partial void Deleterole(role instance);
  partial void Insertuser_name(user_name instance);
  partial void Updateuser_name(user_name instance);
  partial void Deleteuser_name(user_name instance);
  partial void Insertdetail_cart(detail_cart instance);
  partial void Updatedetail_cart(detail_cart instance);
  partial void Deletedetail_cart(detail_cart instance);
  #endregion
	
	public LQDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ProjectFinal"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public LQDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public LQDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public LQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public LQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<cart> carts
	{
		get
		{
			return this.GetTable<cart>();
		}
	}
	
	public System.Data.Linq.Table<cat> cats
	{
		get
		{
			return this.GetTable<cat>();
		}
	}
	
	public System.Data.Linq.Table<cust> custs
	{
		get
		{
			return this.GetTable<cust>();
		}
	}
	
	public System.Data.Linq.Table<img_prod> img_prods
	{
		get
		{
			return this.GetTable<img_prod>();
		}
	}
	
	public System.Data.Linq.Table<prod> prods
	{
		get
		{
			return this.GetTable<prod>();
		}
	}
	
	public System.Data.Linq.Table<role> roles
	{
		get
		{
			return this.GetTable<role>();
		}
	}
	
	public System.Data.Linq.Table<user_name> user_names
	{
		get
		{
			return this.GetTable<user_name>();
		}
	}
	
	public System.Data.Linq.Table<detail_cart> detail_carts
	{
		get
		{
			return this.GetTable<detail_cart>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cart")]
public partial class cart : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id_cart;
	
	private System.Nullable<int> _id_cus;
	
	private System.Nullable<System.DateTime> _time_cart;
	
	private EntitySet<detail_cart> _detail_carts;
	
	private EntityRef<cust> _cust;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_cartChanging(int value);
    partial void Onid_cartChanged();
    partial void Onid_cusChanging(System.Nullable<int> value);
    partial void Onid_cusChanged();
    partial void Ontime_cartChanging(System.Nullable<System.DateTime> value);
    partial void Ontime_cartChanged();
    #endregion
	
	public cart()
	{
		this._detail_carts = new EntitySet<detail_cart>(new Action<detail_cart>(this.attach_detail_carts), new Action<detail_cart>(this.detach_detail_carts));
		this._cust = default(EntityRef<cust>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_cart", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id_cart
	{
		get
		{
			return this._id_cart;
		}
		set
		{
			if ((this._id_cart != value))
			{
				this.Onid_cartChanging(value);
				this.SendPropertyChanging();
				this._id_cart = value;
				this.SendPropertyChanged("id_cart");
				this.Onid_cartChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_cus", DbType="Int")]
	public System.Nullable<int> id_cus
	{
		get
		{
			return this._id_cus;
		}
		set
		{
			if ((this._id_cus != value))
			{
				if (this._cust.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onid_cusChanging(value);
				this.SendPropertyChanging();
				this._id_cus = value;
				this.SendPropertyChanged("id_cus");
				this.Onid_cusChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_time_cart", DbType="Date")]
	public System.Nullable<System.DateTime> time_cart
	{
		get
		{
			return this._time_cart;
		}
		set
		{
			if ((this._time_cart != value))
			{
				this.Ontime_cartChanging(value);
				this.SendPropertyChanging();
				this._time_cart = value;
				this.SendPropertyChanged("time_cart");
				this.Ontime_cartChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cart_detail_cart", Storage="_detail_carts", ThisKey="id_cart", OtherKey="id_cart")]
	public EntitySet<detail_cart> detail_carts
	{
		get
		{
			return this._detail_carts;
		}
		set
		{
			this._detail_carts.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cust_cart", Storage="_cust", ThisKey="id_cus", OtherKey="id_cus", IsForeignKey=true)]
	public cust cust
	{
		get
		{
			return this._cust.Entity;
		}
		set
		{
			cust previousValue = this._cust.Entity;
			if (((previousValue != value) 
						|| (this._cust.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._cust.Entity = null;
					previousValue.carts.Remove(this);
				}
				this._cust.Entity = value;
				if ((value != null))
				{
					value.carts.Add(this);
					this._id_cus = value.id_cus;
				}
				else
				{
					this._id_cus = default(Nullable<int>);
				}
				this.SendPropertyChanged("cust");
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
	
	private void attach_detail_carts(detail_cart entity)
	{
		this.SendPropertyChanging();
		entity.cart = this;
	}
	
	private void detach_detail_carts(detail_cart entity)
	{
		this.SendPropertyChanging();
		entity.cart = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cat")]
public partial class cat : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id_cat;
	
	private string _cat_name;
	
	private EntitySet<prod> _prods;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_catChanging(int value);
    partial void Onid_catChanged();
    partial void Oncat_nameChanging(string value);
    partial void Oncat_nameChanged();
    #endregion
	
	public cat()
	{
		this._prods = new EntitySet<prod>(new Action<prod>(this.attach_prods), new Action<prod>(this.detach_prods));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_cat", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id_cat
	{
		get
		{
			return this._id_cat;
		}
		set
		{
			if ((this._id_cat != value))
			{
				this.Onid_catChanging(value);
				this.SendPropertyChanging();
				this._id_cat = value;
				this.SendPropertyChanged("id_cat");
				this.Onid_catChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cat_name", DbType="NVarChar(50)")]
	public string cat_name
	{
		get
		{
			return this._cat_name;
		}
		set
		{
			if ((this._cat_name != value))
			{
				this.Oncat_nameChanging(value);
				this.SendPropertyChanging();
				this._cat_name = value;
				this.SendPropertyChanged("cat_name");
				this.Oncat_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cat_prod", Storage="_prods", ThisKey="id_cat", OtherKey="id_cat")]
	public EntitySet<prod> prods
	{
		get
		{
			return this._prods;
		}
		set
		{
			this._prods.Assign(value);
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
	
	private void attach_prods(prod entity)
	{
		this.SendPropertyChanging();
		entity.cat = this;
	}
	
	private void detach_prods(prod entity)
	{
		this.SendPropertyChanging();
		entity.cat = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cust")]
public partial class cust : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id_cus;
	
	private string _cus_name;
	
	private string _email;
	
	private EntitySet<cart> _carts;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_cusChanging(int value);
    partial void Onid_cusChanged();
    partial void Oncus_nameChanging(string value);
    partial void Oncus_nameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    #endregion
	
	public cust()
	{
		this._carts = new EntitySet<cart>(new Action<cart>(this.attach_carts), new Action<cart>(this.detach_carts));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_cus", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id_cus
	{
		get
		{
			return this._id_cus;
		}
		set
		{
			if ((this._id_cus != value))
			{
				this.Onid_cusChanging(value);
				this.SendPropertyChanging();
				this._id_cus = value;
				this.SendPropertyChanged("id_cus");
				this.Onid_cusChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cus_name", DbType="NVarChar(50)")]
	public string cus_name
	{
		get
		{
			return this._cus_name;
		}
		set
		{
			if ((this._cus_name != value))
			{
				this.Oncus_nameChanging(value);
				this.SendPropertyChanging();
				this._cus_name = value;
				this.SendPropertyChanged("cus_name");
				this.Oncus_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(100)")]
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
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cust_cart", Storage="_carts", ThisKey="id_cus", OtherKey="id_cus")]
	public EntitySet<cart> carts
	{
		get
		{
			return this._carts;
		}
		set
		{
			this._carts.Assign(value);
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
	
	private void attach_carts(cart entity)
	{
		this.SendPropertyChanging();
		entity.cust = this;
	}
	
	private void detach_carts(cart entity)
	{
		this.SendPropertyChanging();
		entity.cust = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.img_prod")]
public partial class img_prod : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id_img;
	
	private System.Nullable<int> _id_prod;
	
	private string _img_url;
	
	private System.Nullable<int> _stt_img;
	
	private EntityRef<prod> _prod;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_imgChanging(int value);
    partial void Onid_imgChanged();
    partial void Onid_prodChanging(System.Nullable<int> value);
    partial void Onid_prodChanged();
    partial void Onimg_urlChanging(string value);
    partial void Onimg_urlChanged();
    partial void Onstt_imgChanging(System.Nullable<int> value);
    partial void Onstt_imgChanged();
    #endregion
	
	public img_prod()
	{
		this._prod = default(EntityRef<prod>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_img", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id_img
	{
		get
		{
			return this._id_img;
		}
		set
		{
			if ((this._id_img != value))
			{
				this.Onid_imgChanging(value);
				this.SendPropertyChanging();
				this._id_img = value;
				this.SendPropertyChanged("id_img");
				this.Onid_imgChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_prod", DbType="Int")]
	public System.Nullable<int> id_prod
	{
		get
		{
			return this._id_prod;
		}
		set
		{
			if ((this._id_prod != value))
			{
				if (this._prod.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onid_prodChanging(value);
				this.SendPropertyChanging();
				this._id_prod = value;
				this.SendPropertyChanged("id_prod");
				this.Onid_prodChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_img_url", DbType="NVarChar(100)")]
	public string img_url
	{
		get
		{
			return this._img_url;
		}
		set
		{
			if ((this._img_url != value))
			{
				this.Onimg_urlChanging(value);
				this.SendPropertyChanging();
				this._img_url = value;
				this.SendPropertyChanged("img_url");
				this.Onimg_urlChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stt_img", DbType="Int")]
	public System.Nullable<int> stt_img
	{
		get
		{
			return this._stt_img;
		}
		set
		{
			if ((this._stt_img != value))
			{
				this.Onstt_imgChanging(value);
				this.SendPropertyChanging();
				this._stt_img = value;
				this.SendPropertyChanged("stt_img");
				this.Onstt_imgChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="prod_img_prod", Storage="_prod", ThisKey="id_prod", OtherKey="id_pro", IsForeignKey=true)]
	public prod prod
	{
		get
		{
			return this._prod.Entity;
		}
		set
		{
			prod previousValue = this._prod.Entity;
			if (((previousValue != value) 
						|| (this._prod.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._prod.Entity = null;
					previousValue.img_prods.Remove(this);
				}
				this._prod.Entity = value;
				if ((value != null))
				{
					value.img_prods.Add(this);
					this._id_prod = value.id_pro;
				}
				else
				{
					this._id_prod = default(Nullable<int>);
				}
				this.SendPropertyChanged("prod");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.prod")]
public partial class prod : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id_cat;
	
	private int _id_pro;
	
	private string _pro_name;
	
	private System.Nullable<double> _pro_price;
	
	private EntitySet<img_prod> _img_prods;
	
	private EntitySet<detail_cart> _detail_carts;
	
	private EntityRef<cat> _cat;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_catChanging(int value);
    partial void Onid_catChanged();
    partial void Onid_proChanging(int value);
    partial void Onid_proChanged();
    partial void Onpro_nameChanging(string value);
    partial void Onpro_nameChanged();
    partial void Onpro_priceChanging(System.Nullable<double> value);
    partial void Onpro_priceChanged();
    #endregion
	
	public prod()
	{
		this._img_prods = new EntitySet<img_prod>(new Action<img_prod>(this.attach_img_prods), new Action<img_prod>(this.detach_img_prods));
		this._detail_carts = new EntitySet<detail_cart>(new Action<detail_cart>(this.attach_detail_carts), new Action<detail_cart>(this.detach_detail_carts));
		this._cat = default(EntityRef<cat>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_cat", DbType="Int NOT NULL")]
	public int id_cat
	{
		get
		{
			return this._id_cat;
		}
		set
		{
			if ((this._id_cat != value))
			{
				if (this._cat.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onid_catChanging(value);
				this.SendPropertyChanging();
				this._id_cat = value;
				this.SendPropertyChanged("id_cat");
				this.Onid_catChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_pro", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id_pro
	{
		get
		{
			return this._id_pro;
		}
		set
		{
			if ((this._id_pro != value))
			{
				this.Onid_proChanging(value);
				this.SendPropertyChanging();
				this._id_pro = value;
				this.SendPropertyChanged("id_pro");
				this.Onid_proChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_name", DbType="NVarChar(50)")]
	public string pro_name
	{
		get
		{
			return this._pro_name;
		}
		set
		{
			if ((this._pro_name != value))
			{
				this.Onpro_nameChanging(value);
				this.SendPropertyChanging();
				this._pro_name = value;
				this.SendPropertyChanged("pro_name");
				this.Onpro_nameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_price", DbType="Float")]
	public System.Nullable<double> pro_price
	{
		get
		{
			return this._pro_price;
		}
		set
		{
			if ((this._pro_price != value))
			{
				this.Onpro_priceChanging(value);
				this.SendPropertyChanging();
				this._pro_price = value;
				this.SendPropertyChanged("pro_price");
				this.Onpro_priceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="prod_img_prod", Storage="_img_prods", ThisKey="id_pro", OtherKey="id_prod")]
	public EntitySet<img_prod> img_prods
	{
		get
		{
			return this._img_prods;
		}
		set
		{
			this._img_prods.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="prod_detail_cart", Storage="_detail_carts", ThisKey="id_pro", OtherKey="id_pro")]
	public EntitySet<detail_cart> detail_carts
	{
		get
		{
			return this._detail_carts;
		}
		set
		{
			this._detail_carts.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cat_prod", Storage="_cat", ThisKey="id_cat", OtherKey="id_cat", IsForeignKey=true)]
	public cat cat
	{
		get
		{
			return this._cat.Entity;
		}
		set
		{
			cat previousValue = this._cat.Entity;
			if (((previousValue != value) 
						|| (this._cat.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._cat.Entity = null;
					previousValue.prods.Remove(this);
				}
				this._cat.Entity = value;
				if ((value != null))
				{
					value.prods.Add(this);
					this._id_cat = value.id_cat;
				}
				else
				{
					this._id_cat = default(int);
				}
				this.SendPropertyChanged("cat");
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
	
	private void attach_img_prods(img_prod entity)
	{
		this.SendPropertyChanging();
		entity.prod = this;
	}
	
	private void detach_img_prods(img_prod entity)
	{
		this.SendPropertyChanging();
		entity.prod = null;
	}
	
	private void attach_detail_carts(detail_cart entity)
	{
		this.SendPropertyChanging();
		entity.prod = this;
	}
	
	private void detach_detail_carts(detail_cart entity)
	{
		this.SendPropertyChanging();
		entity.prod = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.role")]
public partial class role : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id_usrole;
	
	private string _user_role;
	
	private EntitySet<user_name> _user_names;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_usroleChanging(int value);
    partial void Onid_usroleChanged();
    partial void Onuser_roleChanging(string value);
    partial void Onuser_roleChanged();
    #endregion
	
	public role()
	{
		this._user_names = new EntitySet<user_name>(new Action<user_name>(this.attach_user_names), new Action<user_name>(this.detach_user_names));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_usrole", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id_usrole
	{
		get
		{
			return this._id_usrole;
		}
		set
		{
			if ((this._id_usrole != value))
			{
				this.Onid_usroleChanging(value);
				this.SendPropertyChanging();
				this._id_usrole = value;
				this.SendPropertyChanged("id_usrole");
				this.Onid_usroleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_role", DbType="NVarChar(10)")]
	public string user_role
	{
		get
		{
			return this._user_role;
		}
		set
		{
			if ((this._user_role != value))
			{
				this.Onuser_roleChanging(value);
				this.SendPropertyChanging();
				this._user_role = value;
				this.SendPropertyChanged("user_role");
				this.Onuser_roleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="role_user_name", Storage="_user_names", ThisKey="id_usrole", OtherKey="id_usrole")]
	public EntitySet<user_name> user_names
	{
		get
		{
			return this._user_names;
		}
		set
		{
			this._user_names.Assign(value);
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
	
	private void attach_user_names(user_name entity)
	{
		this.SendPropertyChanging();
		entity.role = this;
	}
	
	private void detach_user_names(user_name entity)
	{
		this.SendPropertyChanging();
		entity.role = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.user_name")]
public partial class user_name : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id_usrole;
	
	private int _id_user;
	
	private string _email;
	
	private string _usFulname;
	
	private string _user_name1;
	
	private string _password;
	
	private System.Nullable<int> _usAge;
	
	private string _usImg;
	
	private EntityRef<role> _role;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_usroleChanging(int value);
    partial void Onid_usroleChanged();
    partial void Onid_userChanging(int value);
    partial void Onid_userChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnusFulnameChanging(string value);
    partial void OnusFulnameChanged();
    partial void Onuser_name1Changing(string value);
    partial void Onuser_name1Changed();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnusAgeChanging(System.Nullable<int> value);
    partial void OnusAgeChanged();
    partial void OnusImgChanging(string value);
    partial void OnusImgChanged();
    #endregion
	
	public user_name()
	{
		this._role = default(EntityRef<role>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_usrole", DbType="Int NOT NULL")]
	public int id_usrole
	{
		get
		{
			return this._id_usrole;
		}
		set
		{
			if ((this._id_usrole != value))
			{
				if (this._role.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onid_usroleChanging(value);
				this.SendPropertyChanging();
				this._id_usrole = value;
				this.SendPropertyChanged("id_usrole");
				this.Onid_usroleChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_user", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id_user
	{
		get
		{
			return this._id_user;
		}
		set
		{
			if ((this._id_user != value))
			{
				this.Onid_userChanging(value);
				this.SendPropertyChanging();
				this._id_user = value;
				this.SendPropertyChanged("id_user");
				this.Onid_userChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(100)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usFulname", DbType="NVarChar(50)")]
	public string usFulname
	{
		get
		{
			return this._usFulname;
		}
		set
		{
			if ((this._usFulname != value))
			{
				this.OnusFulnameChanging(value);
				this.SendPropertyChanging();
				this._usFulname = value;
				this.SendPropertyChanged("usFulname");
				this.OnusFulnameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Name="user_name", Storage="_user_name1", DbType="NVarChar(50)")]
	public string user_name1
	{
		get
		{
			return this._user_name1;
		}
		set
		{
			if ((this._user_name1 != value))
			{
				this.Onuser_name1Changing(value);
				this.SendPropertyChanging();
				this._user_name1 = value;
				this.SendPropertyChanged("user_name1");
				this.Onuser_name1Changed();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50)")]
	public string password
	{
		get
		{
			return this._password;
		}
		set
		{
			if ((this._password != value))
			{
				this.OnpasswordChanging(value);
				this.SendPropertyChanging();
				this._password = value;
				this.SendPropertyChanged("password");
				this.OnpasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usAge", DbType="Int")]
	public System.Nullable<int> usAge
	{
		get
		{
			return this._usAge;
		}
		set
		{
			if ((this._usAge != value))
			{
				this.OnusAgeChanging(value);
				this.SendPropertyChanging();
				this._usAge = value;
				this.SendPropertyChanged("usAge");
				this.OnusAgeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usImg", DbType="NVarChar(100)")]
	public string usImg
	{
		get
		{
			return this._usImg;
		}
		set
		{
			if ((this._usImg != value))
			{
				this.OnusImgChanging(value);
				this.SendPropertyChanging();
				this._usImg = value;
				this.SendPropertyChanged("usImg");
				this.OnusImgChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="role_user_name", Storage="_role", ThisKey="id_usrole", OtherKey="id_usrole", IsForeignKey=true)]
	public role role
	{
		get
		{
			return this._role.Entity;
		}
		set
		{
			role previousValue = this._role.Entity;
			if (((previousValue != value) 
						|| (this._role.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._role.Entity = null;
					previousValue.user_names.Remove(this);
				}
				this._role.Entity = value;
				if ((value != null))
				{
					value.user_names.Add(this);
					this._id_usrole = value.id_usrole;
				}
				else
				{
					this._id_usrole = default(int);
				}
				this.SendPropertyChanged("role");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.detail_cart")]
public partial class detail_cart : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id_dtcart;
	
	private int _id_cart;
	
	private int _id_pro;
	
	private int _quanlity;
	
	private System.Nullable<double> _TTprice;
	
	private EntityRef<cart> _cart;
	
	private EntityRef<prod> _prod;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_dtcartChanging(int value);
    partial void Onid_dtcartChanged();
    partial void Onid_cartChanging(int value);
    partial void Onid_cartChanged();
    partial void Onid_proChanging(int value);
    partial void Onid_proChanged();
    partial void OnquanlityChanging(int value);
    partial void OnquanlityChanged();
    partial void OnTTpriceChanging(System.Nullable<double> value);
    partial void OnTTpriceChanged();
    #endregion
	
	public detail_cart()
	{
		this._cart = default(EntityRef<cart>);
		this._prod = default(EntityRef<prod>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_dtcart", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id_dtcart
	{
		get
		{
			return this._id_dtcart;
		}
		set
		{
			if ((this._id_dtcart != value))
			{
				this.Onid_dtcartChanging(value);
				this.SendPropertyChanging();
				this._id_dtcart = value;
				this.SendPropertyChanged("id_dtcart");
				this.Onid_dtcartChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_cart", DbType="Int NOT NULL")]
	public int id_cart
	{
		get
		{
			return this._id_cart;
		}
		set
		{
			if ((this._id_cart != value))
			{
				if (this._cart.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onid_cartChanging(value);
				this.SendPropertyChanging();
				this._id_cart = value;
				this.SendPropertyChanged("id_cart");
				this.Onid_cartChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_pro", DbType="Int NOT NULL")]
	public int id_pro
	{
		get
		{
			return this._id_pro;
		}
		set
		{
			if ((this._id_pro != value))
			{
				if (this._prod.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.Onid_proChanging(value);
				this.SendPropertyChanging();
				this._id_pro = value;
				this.SendPropertyChanged("id_pro");
				this.Onid_proChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quanlity", DbType="Int NOT NULL")]
	public int quanlity
	{
		get
		{
			return this._quanlity;
		}
		set
		{
			if ((this._quanlity != value))
			{
				this.OnquanlityChanging(value);
				this.SendPropertyChanging();
				this._quanlity = value;
				this.SendPropertyChanged("quanlity");
				this.OnquanlityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TTprice", DbType="Float")]
	public System.Nullable<double> TTprice
	{
		get
		{
			return this._TTprice;
		}
		set
		{
			if ((this._TTprice != value))
			{
				this.OnTTpriceChanging(value);
				this.SendPropertyChanging();
				this._TTprice = value;
				this.SendPropertyChanged("TTprice");
				this.OnTTpriceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cart_detail_cart", Storage="_cart", ThisKey="id_cart", OtherKey="id_cart", IsForeignKey=true)]
	public cart cart
	{
		get
		{
			return this._cart.Entity;
		}
		set
		{
			cart previousValue = this._cart.Entity;
			if (((previousValue != value) 
						|| (this._cart.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._cart.Entity = null;
					previousValue.detail_carts.Remove(this);
				}
				this._cart.Entity = value;
				if ((value != null))
				{
					value.detail_carts.Add(this);
					this._id_cart = value.id_cart;
				}
				else
				{
					this._id_cart = default(int);
				}
				this.SendPropertyChanged("cart");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="prod_detail_cart", Storage="_prod", ThisKey="id_pro", OtherKey="id_pro", IsForeignKey=true)]
	public prod prod
	{
		get
		{
			return this._prod.Entity;
		}
		set
		{
			prod previousValue = this._prod.Entity;
			if (((previousValue != value) 
						|| (this._prod.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._prod.Entity = null;
					previousValue.detail_carts.Remove(this);
				}
				this._prod.Entity = value;
				if ((value != null))
				{
					value.detail_carts.Add(this);
					this._id_pro = value.id_pro;
				}
				else
				{
					this._id_pro = default(int);
				}
				this.SendPropertyChanged("prod");
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
#pragma warning restore 1591
