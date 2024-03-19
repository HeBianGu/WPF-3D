using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSQLDatabaseTableSource
	/// </summary>
	/// <remarks>
	///    Generates a vtkTable based on an SQL query.
	///
	///
	/// This class combines vtkSQLDatabase, vtkSQLQuery, and vtkQueryToTable to
	/// provide a convenience class for generating tables from databases.
	/// Also this class can be easily wrapped and used within ParaView / OverView.
	/// </remarks>
	// Token: 0x0200026D RID: 621
	public class vtkSQLDatabaseTableSource : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007153 RID: 29011 RVA: 0x000A361F File Offset: 0x000A181F
		static vtkSQLDatabaseTableSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLDatabaseTableSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLDatabaseTableSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007154 RID: 29012 RVA: 0x000A3647 File Offset: 0x000A1847
		public vtkSQLDatabaseTableSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007155 RID: 29013
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseTableSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007156 RID: 29014 RVA: 0x000A3658 File Offset: 0x000A1858
		public new static vtkSQLDatabaseTableSource New()
		{
			vtkSQLDatabaseTableSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLDatabaseTableSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007157 RID: 29015 RVA: 0x000A36AC File Offset: 0x000A18AC
		public vtkSQLDatabaseTableSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007158 RID: 29016 RVA: 0x000A36F0 File Offset: 0x000A18F0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007159 RID: 29017
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLDatabaseTableSource_GeneratePedigreeIdsOff_01(HandleRef pThis);

		/// <summary>
		/// If on (default), generates pedigree ids automatically.
		/// If off, assign one of the arrays to be the pedigree id.
		/// </summary>
		// Token: 0x0600715A RID: 29018 RVA: 0x000A36FB File Offset: 0x000A18FB
		public virtual void GeneratePedigreeIdsOff()
		{
			vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_GeneratePedigreeIdsOff_01(base.GetCppThis());
		}

		// Token: 0x0600715B RID: 29019
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLDatabaseTableSource_GeneratePedigreeIdsOn_02(HandleRef pThis);

		/// <summary>
		/// If on (default), generates pedigree ids automatically.
		/// If off, assign one of the arrays to be the pedigree id.
		/// </summary>
		// Token: 0x0600715C RID: 29020 RVA: 0x000A370A File Offset: 0x000A190A
		public virtual void GeneratePedigreeIdsOn()
		{
			vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_GeneratePedigreeIdsOn_02(base.GetCppThis());
		}

		// Token: 0x0600715D RID: 29021
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSQLDatabaseTableSource_GetGeneratePedigreeIds_03(HandleRef pThis);

		/// <summary>
		/// If on (default), generates pedigree ids automatically.
		/// If off, assign one of the arrays to be the pedigree id.
		/// </summary>
		// Token: 0x0600715E RID: 29022 RVA: 0x000A371C File Offset: 0x000A191C
		public virtual bool GetGeneratePedigreeIds()
		{
			return vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_GetGeneratePedigreeIds_03(base.GetCppThis()) != 0;
		}

		// Token: 0x0600715F RID: 29023
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLDatabaseTableSource_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007160 RID: 29024 RVA: 0x000A3744 File Offset: 0x000A1944
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06007161 RID: 29025
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLDatabaseTableSource_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007162 RID: 29026 RVA: 0x000A3764 File Offset: 0x000A1964
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06007163 RID: 29027
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseTableSource_GetPedigreeIdArrayName_06(HandleRef pThis);

		/// <summary>
		/// The name of the array for generating or assigning pedigree ids
		/// (default "id").
		/// </summary>
		// Token: 0x06007164 RID: 29028 RVA: 0x000A3780 File Offset: 0x000A1980
		public virtual string GetPedigreeIdArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_GetPedigreeIdArrayName_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06007165 RID: 29029
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSQLDatabaseTableSource_GetQuery_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007166 RID: 29030 RVA: 0x000A37BC File Offset: 0x000A19BC
		public string GetQuery()
		{
			return vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_GetQuery_07(base.GetCppThis());
		}

		// Token: 0x06007167 RID: 29031
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkSQLDatabaseTableSource_GetURL_08(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007168 RID: 29032 RVA: 0x000A37DC File Offset: 0x000A19DC
		public string GetURL()
		{
			return vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_GetURL_08(base.GetCppThis());
		}

		// Token: 0x06007169 RID: 29033
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseTableSource_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600716A RID: 29034 RVA: 0x000A37FC File Offset: 0x000A19FC
		public override int IsA(string type)
		{
			return vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600716B RID: 29035
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLDatabaseTableSource_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600716C RID: 29036 RVA: 0x000A381C File Offset: 0x000A1A1C
		public new static int IsTypeOf(string type)
		{
			return vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_IsTypeOf_10(type);
		}

		// Token: 0x0600716D RID: 29037
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseTableSource_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600716E RID: 29038 RVA: 0x000A3838 File Offset: 0x000A1A38
		public new vtkSQLDatabaseTableSource NewInstance()
		{
			vtkSQLDatabaseTableSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLDatabaseTableSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600716F RID: 29039
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLDatabaseTableSource_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007170 RID: 29040 RVA: 0x000A3894 File Offset: 0x000A1A94
		public new static vtkSQLDatabaseTableSource SafeDownCast(vtkObjectBase o)
		{
			vtkSQLDatabaseTableSource vtkSQLDatabaseTableSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLDatabaseTableSource = (vtkSQLDatabaseTableSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLDatabaseTableSource.Register(null);
				}
			}
			return vtkSQLDatabaseTableSource;
		}

		// Token: 0x06007171 RID: 29041
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLDatabaseTableSource_SetGeneratePedigreeIds_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on (default), generates pedigree ids automatically.
		/// If off, assign one of the arrays to be the pedigree id.
		/// </summary>
		// Token: 0x06007172 RID: 29042 RVA: 0x000A3913 File Offset: 0x000A1B13
		public virtual void SetGeneratePedigreeIds(bool _arg)
		{
			vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_SetGeneratePedigreeIds_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x06007173 RID: 29043
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLDatabaseTableSource_SetPassword_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string password);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007174 RID: 29044 RVA: 0x000A392B File Offset: 0x000A1B2B
		public void SetPassword(string password)
		{
			vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_SetPassword_15(base.GetCppThis(), password);
		}

		// Token: 0x06007175 RID: 29045
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLDatabaseTableSource_SetPedigreeIdArrayName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the array for generating or assigning pedigree ids
		/// (default "id").
		/// </summary>
		// Token: 0x06007176 RID: 29046 RVA: 0x000A393B File Offset: 0x000A1B3B
		public virtual void SetPedigreeIdArrayName(string _arg)
		{
			vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_SetPedigreeIdArrayName_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06007177 RID: 29047
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLDatabaseTableSource_SetQuery_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string query);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007178 RID: 29048 RVA: 0x000A394B File Offset: 0x000A1B4B
		public void SetQuery(string query)
		{
			vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_SetQuery_17(base.GetCppThis(), query);
		}

		// Token: 0x06007179 RID: 29049
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSQLDatabaseTableSource_SetURL_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string url);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600717A RID: 29050 RVA: 0x000A395B File Offset: 0x000A1B5B
		public void SetURL(string url)
		{
			vtkSQLDatabaseTableSource.vtkSQLDatabaseTableSource_SetURL_18(base.GetCppThis(), url);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009E5 RID: 2533
		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLDatabaseTableSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009E6 RID: 2534
		public new static readonly string MRClassNameKey = "class vtkSQLDatabaseTableSource";
	}
}
