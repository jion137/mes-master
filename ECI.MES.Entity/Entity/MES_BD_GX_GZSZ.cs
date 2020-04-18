#pragma warning disable  1591
using PL.Base;
using System;
using System.Collections.Generic;
using System.Data;
using PL.Server.Entity;
using PL.Server.Entity.Entity;
 
namespace ECI.MES.Entity
{
    public partial class MES_BD_GX_GZSZ : EntityBase
	{
	     public MES_BD_GX_GZSZ()
		 {
		    base.Table = new TableInfo { Name = "MES_BD_GX_GZSZ" };
		    base.Columns = MES_BD_GX_GZSZ_COLUMN.Instance;
			this.Init();
		 }
		
		public MES_BD_GX_GZSZ(string keyField):this()
        {
            base.KeyField =  keyField;
        }

	public MES_BD_GX_GZSZ(string keyField,string keyValue):this()
        {
            base.KeyField =  keyField;
            this[keyField]= keyValue;
        }
		
		
        public MES_BD_GX_GZSZ(EntityBase entityBase)
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
                    ///  MES_BD_GX.GUID
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
                    ///  记录表中是否加入该工种员工框
                    /// </summary>
                    public string IS_ADD
                    {
                        get
                        {
                            return this.TextAccess["IS_ADD"];
                        }
                        set
                        {
                            this.TextAccess["IS_ADD"] = value;
                        }
                    }
                    /// <summary>
                    ///  加入员工框数量
                    /// </summary>
                    public System.Nullable<double> QTY
                    {
                        get
                        {
                            return this.DoubleAccess["QTY"];
                        }
                        set
                        {
                            this.DoubleAccess["QTY"] = value;
                        }
                    }
                    /// <summary>
                    ///  该工种员工产量是否以员工框为准
                    /// </summary>
                    public string IS_WZ
                    {
                        get
                        {
                            return this.TextAccess["IS_WZ"];
                        }
                        set
                        {
                            this.TextAccess["IS_WZ"] = value;
                        }
                    }
                    /// <summary>
                    ///  备注
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
        public MES_BD_GX_GZSZ SingleOrDefault()
        {
           return new EntityBuilder<MES_BD_GX_GZSZ>().ToEntityBySql(this.SQLSelect);
        }

        public MES_BD_GX_GZSZ SingleOrDefault(object ts)
        {
            return new EntityBuilder<MES_BD_GX_GZSZ>().ToEntityBySql(this.SQLSelect, ts);
        }

        public List<MES_BD_GX_GZSZ> ToList()
        {
             return new EntityBuilder<MES_BD_GX_GZSZ>().ToListBySql(this.SQLSelect);
        }
		 
        public List<MES_BD_GX_GZSZ> ToList(object ts)
        {
            return new EntityBuilder<MES_BD_GX_GZSZ>().ToListBySql(this.SQLSelect, ts);
        }
		
		public static MES_BD_GX_GZSZ SingleOrDefault(string sql)
        {
            return SingleOrDefault(sql, null);
        }

        public static MES_BD_GX_GZSZ SingleOrDefault(string sql,object ts)
        {
            List<MES_BD_GX_GZSZ> list = ToListBySql(sql, ts);

            if (list.Count == 0) return null;
            else
            {
                return list[0];
            }
        }
		
		public static  List<MES_BD_GX_GZSZ> ToListBySql(string sql)
        {
            return ToListBySql(sql, null);
        }

        public static List<MES_BD_GX_GZSZ> ToListBySql(string sql, object ts)
        {
            return new EntityBuilder<MES_BD_GX_GZSZ>().ToListBySql(sql, ts);
        }
		
		public static List<MES_BD_GX_GZSZ> ToList(DataTable data)
        {
            return new EntityBuilder<MES_BD_GX_GZSZ>().ToList(data);
        }
		
		
		#endregion
		
	    public static TDAL<MES_BD_GX_GZSZ, MES_BD_GX_GZSZ_FIELD> DAL
        {
            get
            {
                return new TDAL<MES_BD_GX_GZSZ, MES_BD_GX_GZSZ_FIELD>();
            }
        }
		
	    public static MES_BD_GX_GZSZ_FIELD Fields
        {
            get { return MES_BD_GX_GZSZ_FIELD.Instance; }
        }
		
	
		public static EntityBuilder<MES_BD_GX_GZSZ> EntityBuilder = new EntityBuilder<MES_BD_GX_GZSZ>();
    }

	internal class MES_BD_GX_GZSZ_COLUMN : BaseColumn
    {
        public static MES_BD_GX_GZSZ_COLUMN Instance;

        static MES_BD_GX_GZSZ_COLUMN()
        {
            Instance = new MES_BD_GX_GZSZ_COLUMN();
        }

        private MES_BD_GX_GZSZ_COLUMN()
        {
               base.ListColumn.Add(new ColumnInfo() { Name = "GUID", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "FGUID", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "IS_ADD", Type = "TEXT"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "QTY", Type = "NUMBER"  });
               base.ListColumn.Add(new ColumnInfo() { Name = "IS_WZ", Type = "TEXT"  });
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
	
  public class  MES_BD_GX_GZSZ_FIELD
  {
       private static MES_BD_GX_GZSZ_FIELD instance;

        public static MES_BD_GX_GZSZ_FIELD Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MES_BD_GX_GZSZ_FIELD();
                }

                return instance;
            }
        }
		
                    public readonly string GUID = "GUID";
        public readonly string FGUID = "FGUID";
        public readonly string IS_ADD = "IS_ADD";
        public readonly string QTY = "QTY";
        public readonly string IS_WZ = "IS_WZ";
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