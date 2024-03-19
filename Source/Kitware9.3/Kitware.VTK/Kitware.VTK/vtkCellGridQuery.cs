using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridQuery
	/// </summary>
	/// <remarks>
	///    Perform an operation on cells in a vtkCellMetadata instance.
	///
	/// This is an empty base class that all query types must inherit.
	///
	/// The `vtkCellGrid::Query()` method calls the query's `Initialize()` implementation;
	/// then loops over all its cell-types (calling the best-matching responder's `Query()`
	/// method for that cell-type); then calls `Finalize()`.
	///
	/// The responders have an opportunity to modify the state of the query object,
	/// so these methods are a chance to prepare your query's state and then perform
	/// reduce-like computations after all the cells have been handled.
	/// </remarks>
	// Token: 0x020001D9 RID: 473
	public class vtkCellGridQuery : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005A9B RID: 23195 RVA: 0x00083027 File Offset: 0x00081227
		static vtkCellGridQuery()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridQuery.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridQuery"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005A9C RID: 23196 RVA: 0x0008304F File Offset: 0x0008124F
		public vtkCellGridQuery(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005A9D RID: 23197 RVA: 0x0008305D File Offset: 0x0008125D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005A9E RID: 23198
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridQuery_Finalize_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A9F RID: 23199 RVA: 0x00083068 File Offset: 0x00081268
		public virtual void FinalizeWrapper()
		{
			vtkCellGridQuery.vtkCellGridQuery_Finalize_01(base.GetCppThis());
		}

		// Token: 0x06005AA0 RID: 23200
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridQuery_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AA1 RID: 23201 RVA: 0x00083078 File Offset: 0x00081278
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridQuery.vtkCellGridQuery_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005AA2 RID: 23202
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridQuery_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AA3 RID: 23203 RVA: 0x00083098 File Offset: 0x00081298
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridQuery.vtkCellGridQuery_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005AA4 RID: 23204
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridQuery_GetPass_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AA5 RID: 23205 RVA: 0x000830B4 File Offset: 0x000812B4
		public virtual int GetPass()
		{
			return vtkCellGridQuery.vtkCellGridQuery_GetPass_04(base.GetCppThis());
		}

		// Token: 0x06005AA6 RID: 23206
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridQuery_Initialize_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AA7 RID: 23207 RVA: 0x000830D3 File Offset: 0x000812D3
		public virtual void Initialize()
		{
			vtkCellGridQuery.vtkCellGridQuery_Initialize_05(base.GetCppThis());
		}

		// Token: 0x06005AA8 RID: 23208
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridQuery_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AA9 RID: 23209 RVA: 0x000830E4 File Offset: 0x000812E4
		public override int IsA(string type)
		{
			return vtkCellGridQuery.vtkCellGridQuery_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06005AAA RID: 23210
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellGridQuery_IsAnotherPassRequired_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AAB RID: 23211 RVA: 0x00083104 File Offset: 0x00081304
		public virtual bool IsAnotherPassRequired()
		{
			return vtkCellGridQuery.vtkCellGridQuery_IsAnotherPassRequired_07(base.GetCppThis()) != 0;
		}

		// Token: 0x06005AAC RID: 23212
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridQuery_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AAD RID: 23213 RVA: 0x0008312C File Offset: 0x0008132C
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridQuery.vtkCellGridQuery_IsTypeOf_08(type);
		}

		// Token: 0x06005AAE RID: 23214
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridQuery_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AAF RID: 23215 RVA: 0x00083148 File Offset: 0x00081348
		public new vtkCellGridQuery NewInstance()
		{
			vtkCellGridQuery result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridQuery.vtkCellGridQuery_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005AB0 RID: 23216
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridQuery_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AB1 RID: 23217 RVA: 0x000831A4 File Offset: 0x000813A4
		public new static vtkCellGridQuery SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridQuery vtkCellGridQuery = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridQuery.vtkCellGridQuery_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridQuery = (vtkCellGridQuery)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridQuery.Register(null);
				}
			}
			return vtkCellGridQuery;
		}

		// Token: 0x06005AB2 RID: 23218
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridQuery_StartPass_11(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005AB3 RID: 23219 RVA: 0x00083223 File Offset: 0x00081423
		public virtual void StartPass()
		{
			vtkCellGridQuery.vtkCellGridQuery_StartPass_11(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400087B RID: 2171
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridQuery";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400087C RID: 2172
		public new static readonly string MRClassNameKey = "class vtkCellGridQuery";
	}
}
