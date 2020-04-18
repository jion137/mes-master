#pragma warning disable  1591
using PL.Base;
using System;
using System.Collections.Generic;
using System.Data;
using PL.Server.Entity;
using PL.Server.Entity.Entity;
 
namespace ECI.MES.Entity
{
    public partial class MES_BD_WLPL_CPXS : EntityBase
	{
	     public MES_BD_WLPL_CPXS()
		 {
		    base.Table = new TableInfo { Name = "MES_BD_WLPL_CPXS" };
		    base.Columns = MES_BD_WLPL_CPXS_COLUMN.Instance;
			this.Init();
		 }
		
		public MES_BD_WLPL_CPXS(string keyField):this()
        {
            base.KeyField =  keyField;
        }

	public MES_BD_WLPL_CPXS(string keyField,string keyValue):this()
        {
            base.KeyField =  keyField;
            this[keyField]= keyValue;
        }
		
		
        public MES_BD_WLPL_CPXS(EntityBase entityBase)
            : this()
        {
            this.Data = entityBase.Data;
        }
 
		#region DataMember
		
                                                     /// <summary>
                    ///  
                    /// </summary>
                    public string GUID
                    {
                        get
                        {
                            return this.TextAccess["GUID"];
                        }
                        set
                        {
                            this.TextAccess["GUID"] = value;
                        }
                    }
                    /// <summary>
                    ///  MES_BD_WLPL.GUID
                    /// </summary>
                    public string FGUID
                    {
                        get
                        {
                            return this.TextAccess["FGUID"];
                        }
                        set
                        {
                            this.TextAccess["FGUID"] = value;
                        }
                    }
                    /// <summary>
                    ///  编号
                    /// </summary>
                    public string BH
                    {
                        get
                        {
                            return this.TextAccess["BH"];
                        }
                        set
                        {
                            this.TextAccess["BH"] = value;
                        }
                    }
                    /// <summary>
                    ///  物料品类名
                    /// </summary>
                    public string NAME
                    {
                        get
                        {
                            return this.TextAccess["NAME"];
                        }
                        set
                        {
                            this.TextAccess["NAME"] = value;
                        }
                    }
                    /// <summary>
                    ///  对应产品型式
                    /// </summary>
                    public string CPXS
                    {
                        get
                        {
                            return this.TextAccess["CPXS"];
                        }
                        set
                        {
                            this.TextAccess["CPXS"] = value;
                        }
                    }
                    /// <summary>
                    ///  优先级别
                    /// </summary>
                    public string CPXS_LEVEL
                    {
                        get
                        {
                            return this.TextAccess["CPXS_LEVEL"];
                        }
                        set
                        {
                            this.TextAccess["CPXS_LEVEL"] = value;
                        }
                    }
                    /// <summary>
                    ///  产品型式1备注
                    /// </summary>
                    public string REMARK
                    {
                        get
                        {
                            return this.TextAccess["REMARK"];
                        }
                        set
                        {
                            this.TextAccess["REMARK"] = value;
                        }
                    }
                    /// <summary>
                    ///  
                    /// </summary>
                    public string CREATE_USER
                    {
                        get
                        {
                            return this.TextAccess["CREATE_USER"];
                        }
                        set
                        {
                            this.TextAccess["CREATE_USER"] = value;
                        }
                    }
                    /// <summary>
                    ///  
                    /// </summary>
                    public string CREATE_USER_NAME
                    {
                        get
                        {
                            return this.TextAccess["CREATE_USER_NAME"];
                        }
                        set
                        {
                            this.TextAccess["CREATE_USER_NAME"] = value;
                        }
                    }
                    /// <summary>
                    ///  
                    /// </summary>
                    public System.Nullable<DateTime> CREATE_DATE
                    {
                        get
                        {
                            return this.DateAccess["CREATE_DATE"];
                        }
                        set
                        {
                            this.DateAccess["CREATE_DATE"] = value;
                        }
                    }
                    /// <summary>
                    ///  
                    /// </summary>
                    public string UPDATE_USER
                    {
                        get
                        {
                            return this.TextAccess["UPDATE_USER"];
                        }
                        set
                        {
                            this.TextAccess["UPDATE_USER"] = value;
                        }
                    }
                    /// <summary>
                    ///  
                    /// </summary>
                    public string UPDATE_USER_NAME
                    {
                        get
                        {
                            return this.TextAccess["UPDATE_USER_NAME"];
                        }
                        set
                        {
                            this.TextAccess["UPDATE_USER_NAME"] = value;
                        }
                    }
                    /// <summary>
                    ///  
                    /// </summary>
                    public System.Nullable<DateTime> UPDATE_DATE
                    {
                        get
                        {
                            return this.DateAccess["UPDATE_DATE"];
                        }
                        set
                        {
                            this.DateAccess["UPDATE_DATE"] = value;
                        }
                    }
                    /// <summary>
                    ///  
                    /// </summary>
                    public string COMPANY_CODE
                    {
                        get
                        {
                            return this.TextAccess["COMPANY_CODE"];
                        }
                        set
                        {
                            this.TextAccess["COMPANY_CODE"] = value;
                        }
                    }
                    /// <summary>
                    ///  
                    /// </summary>
                    public string COMPANY_NAME
                    {
                        get
                        {
                            return this.TextAccess["COMPANY_NAME"];
                        }
                        set
                        {
                            this.TextAccess["COMPANY_NAME"] = value;
                        }
                    }


		#endregion
	 
	    #region Query Method
        public MES_BD_WLPL_CPXS SingleOrDefault()
        {
           return new EntityBuilder<MES_BD_WLPL_CPXS>().ToEntityBySql(this.SQLSelect);
        }

        public MES_BD_WLPL_CPXS SingleOrDefault(object ts)
        {
            return new EntityBuilder<MES_BD_WLPL_CPXS>().ToEntityBySql(this.SQLSelect, ts);
        }

        public List<MES_BD_WLPL_CPXS> ToList()
        {
             return new EntityBuilder<MES_BD_WLPL_CPXS>().ToListBySql(this.SQLSelect);
        }
		 
        public List<MES_BD_WLPL_CPXS> ToList(object ts)
        {
            return new EntityBuilder<MES_BD_WLPL_CPXS>().ToListBySql(this.SQLSelect, ts);
        }
		
		public static MES_BD_WLPL_CPXS SingleOrDefault(string sql)
        {
            return SingleOrDefault(sql, null);
        }

        public static MES_BD_WLPL_CPXS SingleOrDefault(string sql,object ts)
        {
            List<MES_BD_WLPL_CPXS> list = ToListBySql(sql, ts);

            if (list.Count == 0) return null;
            else
            {
                return list[0];
            }
        }
		
		public static  List<MES_BD_WLPL_CPXS> ToListBySql(string sql)
        {
            return ToListBySql(sql, null);
        }

        public static List<MES_BD_WLPL_CPXS> ToListBySql(string sql, object ts)
        {
            return new EntityBuilder<MES_BD_WLPL_CPXS>().ToListBySql(sql, ts);
        }
		
		public static List<MES_BD_WLPL_CPXS> ToList(DataTable data)
        {
            return new EntityBuilder<MES_BD_WLPL_CPXS>().ToList(data);
        }
		
		
		#endregion
		
	    public static TDAL<MES_BD_WLPL_CPXS, MES_BD_WLPL_CPXS_FIELD> DAL
        {
            get
            {
                return new TDAL<MES_BD_WLPL_CPXS, MES_BD_WLPL_CPXS_FIELD>();
            }
        }
		
	    public static MES_BD_WLPL_CPXS_FIELD Fields
        {
            get { return MES_BD_WLPL_CPXS_FIELD.Instance; }
        }
		
	
		public static EntityBuilder<MES_BD_WLPL_CPXS> EntityBuilder = new EntityBuilder<MES_BD_WLPL_CPXS>();
    }

	internal class MES_BD_WLPL_CPXS_COLUMN : BaseColumn
    {
        public static MES_BD_WLPL_CPXS_COLUMN Instance;

        static MES_BD_WLPL_CPXS_COLUMN()
        {
            Instance = new MES_BD_WLPL_CPXS_COLUMN();
        }

        private MES_BD_WLPL_CPXS_COLUMN()
        {
               base.ListColumn.Add(new ColumnInfo() { Name = "GUID", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "FGUID", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "BH", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "NAME", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "CPXS", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "CPXS_LEVEL", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "REMARK", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "CREATE_USER", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "CREATE_USER_NAME", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "CREATE_DATE", Type = "DATE"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "UPDATE_USER", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "UPDATE_USER_NAME", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "UPDATE_DATE", Type = "DATE"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "COMPANY_CODE", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "COMPANY_NAME", Type = "TEXT"  });

        }
    }
	
  public class  MES_BD_WLPL_CPXS_FIELD
  {
       private static MES_BD_WLPL_CPXS_FIELD instance;

        public static MES_BD_WLPL_CPXS_FIELD Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MES_BD_WLPL_CPXS_FIELD();
                }

                return instance;
            }
        }
		
                    public readonly string GUID = "GUID";
        public readonly string FGUID = "FGUID";
        public readonly string BH = "BH";
        public readonly string NAME = "NAME";
        public readonly string CPXS = "CPXS";
        public readonly string CPXS_LEVEL = "CPXS_LEVEL";
        public readonly string REMARK = "REMARK";
        public readonly string CREATE_USER = "CREATE_USER";
        public readonly string CREATE_USER_NAME = "CREATE_USER_NAME";
        public readonly string CREATE_DATE = "CREATE_DATE";
        public readonly string UPDATE_USER = "UPDATE_USER";
        public readonly string UPDATE_USER_NAME = "UPDATE_USER_NAME";
        public readonly string UPDATE_DATE = "UPDATE_DATE";
        public readonly string COMPANY_CODE = "COMPANY_CODE";
        public readonly string COMPANY_NAME = "COMPANY_NAME";

   }
}