using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridIOQuery
	/// </summary>
	/// <remarks>
	///    Serialize/deserialize vtkCellMetadata records.
	///
	/// vtkCellGridIOQuery is a concrete subclass of vtkCellGridQuery that helps
	/// serialize/deserialize vtkCellGrid objects to/from JSON.
	/// Specifically, it reads/writes data specific to subclasses of vtkCellMetadata.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkCellGridQuery
	/// </seealso>
	// Token: 0x020001DA RID: 474
	public class vtkCellGridIOQuery : vtkCellGridQuery
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005AB4 RID: 23220 RVA: 0x00083232 File Offset: 0x00081432
		static vtkCellGridIOQuery()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridIOQuery.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridIOQuery"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005AB5 RID: 23221 RVA: 0x0008325A File Offset: 0x0008145A
		public vtkCellGridIOQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005AB6 RID: 23222
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridIOQuery_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AB7 RID: 23223 RVA: 0x00083268 File Offset: 0x00081468
		public new static vtkCellGridIOQuery New()
		{
			vtkCellGridIOQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridIOQuery.vtkCellGridIOQuery_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridIOQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AB8 RID: 23224 RVA: 0x000832BC File Offset: 0x000814BC
		public vtkCellGridIOQuery() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridIOQuery.vtkCellGridIOQuery_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005AB9 RID: 23225 RVA: 0x00083300 File Offset: 0x00081500
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005ABA RID: 23226
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridIOQuery_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005ABB RID: 23227 RVA: 0x0008330C File Offset: 0x0008150C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridIOQuery.vtkCellGridIOQuery_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06005ABC RID: 23228
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridIOQuery_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005ABD RID: 23229 RVA: 0x0008332C File Offset: 0x0008152C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridIOQuery.vtkCellGridIOQuery_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06005ABE RID: 23230
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridIOQuery_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005ABF RID: 23231 RVA: 0x00083348 File Offset: 0x00081548
		public override int IsA(string type)
		{
			return vtkCellGridIOQuery.vtkCellGridIOQuery_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06005AC0 RID: 23232
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGridIOQuery_IsSerializing_04(HandleRef pThis);

		/// <summary>
		/// Prepare to serialize cell metadata to the given \a parent JSON object.
		/// </summary>
		// Token: 0x06005AC1 RID: 23233 RVA: 0x00083368 File Offset: 0x00081568
		public bool IsSerializing()
		{
			return vtkCellGridIOQuery.vtkCellGridIOQuery_IsSerializing_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06005AC2 RID: 23234
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridIOQuery_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AC3 RID: 23235 RVA: 0x00083390 File Offset: 0x00081590
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridIOQuery.vtkCellGridIOQuery_IsTypeOf_05(type);
		}

		// Token: 0x06005AC4 RID: 23236
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridIOQuery_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AC5 RID: 23237 RVA: 0x000833AC File Offset: 0x000815AC
		public new vtkCellGridIOQuery NewInstance()
		{
			vtkCellGridIOQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridIOQuery.vtkCellGridIOQuery_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridIOQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005AC6 RID: 23238
		[DllImport("Kitware.VTK.IOCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridIOQuery_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AC7 RID: 23239 RVA: 0x00083408 File Offset: 0x00081608
		public new static vtkCellGridIOQuery SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridIOQuery vtkCellGridIOQuery = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridIOQuery.vtkCellGridIOQuery_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridIOQuery = (vtkCellGridIOQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridIOQuery.Register(null);
				}
			}
			return vtkCellGridIOQuery;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400087D RID: 2173
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridIOQuery";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400087E RID: 2174
		public new static readonly string MRClassNameKey = "class vtkCellGridIOQuery";
	}
}
