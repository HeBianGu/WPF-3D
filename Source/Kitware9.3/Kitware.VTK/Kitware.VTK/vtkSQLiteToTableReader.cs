using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSQLiteToTableReader
	/// </summary>
	/// <remarks>
	///    Read an SQLite table as a vtkTable
	///
	/// vtkSQLiteToTableReader reads a table from an SQLite database and
	/// outputs it as a vtkTable.
	/// </remarks>
	// Token: 0x02000272 RID: 626
	public class vtkSQLiteToTableReader : vtkDatabaseToTableReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06007232 RID: 29234 RVA: 0x000A4B7F File Offset: 0x000A2D7F
		static vtkSQLiteToTableReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSQLiteToTableReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSQLiteToTableReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06007233 RID: 29235 RVA: 0x000A4BA7 File Offset: 0x000A2DA7
		public vtkSQLiteToTableReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06007234 RID: 29236
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteToTableReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007235 RID: 29237 RVA: 0x000A4BB8 File Offset: 0x000A2DB8
		public new static vtkSQLiteToTableReader New()
		{
			vtkSQLiteToTableReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLiteToTableReader.vtkSQLiteToTableReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLiteToTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007236 RID: 29238 RVA: 0x000A4C0C File Offset: 0x000A2E0C
		public vtkSQLiteToTableReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSQLiteToTableReader.vtkSQLiteToTableReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06007237 RID: 29239 RVA: 0x000A4C50 File Offset: 0x000A2E50
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06007238 RID: 29240
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLiteToTableReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007239 RID: 29241 RVA: 0x000A4C5C File Offset: 0x000A2E5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSQLiteToTableReader.vtkSQLiteToTableReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600723A RID: 29242
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSQLiteToTableReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600723B RID: 29243 RVA: 0x000A4C7C File Offset: 0x000A2E7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSQLiteToTableReader.vtkSQLiteToTableReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600723C RID: 29244
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLiteToTableReader_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600723D RID: 29245 RVA: 0x000A4C98 File Offset: 0x000A2E98
		public override int IsA(string type)
		{
			return vtkSQLiteToTableReader.vtkSQLiteToTableReader_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600723E RID: 29246
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSQLiteToTableReader_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600723F RID: 29247 RVA: 0x000A4CB8 File Offset: 0x000A2EB8
		public new static int IsTypeOf(string type)
		{
			return vtkSQLiteToTableReader.vtkSQLiteToTableReader_IsTypeOf_04(type);
		}

		// Token: 0x06007240 RID: 29248
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteToTableReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007241 RID: 29249 RVA: 0x000A4CD4 File Offset: 0x000A2ED4
		public new vtkSQLiteToTableReader NewInstance()
		{
			vtkSQLiteToTableReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLiteToTableReader.vtkSQLiteToTableReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSQLiteToTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06007242 RID: 29250
		[DllImport("Kitware.VTK.IOSQL.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSQLiteToTableReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06007243 RID: 29251 RVA: 0x000A4D30 File Offset: 0x000A2F30
		public new static vtkSQLiteToTableReader SafeDownCast(vtkObjectBase o)
		{
			vtkSQLiteToTableReader vtkSQLiteToTableReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSQLiteToTableReader.vtkSQLiteToTableReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSQLiteToTableReader = (vtkSQLiteToTableReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSQLiteToTableReader.Register(null);
				}
			}
			return vtkSQLiteToTableReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009F2 RID: 2546
		public new const string MRFullTypeName = "Kitware.VTK.vtkSQLiteToTableReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009F3 RID: 2547
		public new static readonly string MRClassNameKey = "class vtkSQLiteToTableReader";
	}
}
