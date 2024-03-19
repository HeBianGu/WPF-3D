using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPLinearExtrusionFilter
	/// </summary>
	/// <remarks>
	///    Subclass that handles piece invariance.
	///
	/// vtkPLinearExtrusionFilter is a parallel version of vtkLinearExtrusionFilter.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkLinearExtrusionFilter
	/// </seealso>
	// Token: 0x0200051B RID: 1307
	public class vtkPLinearExtrusionFilter : vtkLinearExtrusionFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EA4C RID: 59980 RVA: 0x00146BC8 File Offset: 0x00144DC8
		static vtkPLinearExtrusionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPLinearExtrusionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPLinearExtrusionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EA4D RID: 59981 RVA: 0x00146BF0 File Offset: 0x00144DF0
		public vtkPLinearExtrusionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EA4E RID: 59982
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLinearExtrusionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create an object with PieceInvariant off.
		/// </summary>
		// Token: 0x0600EA4F RID: 59983 RVA: 0x00146C00 File Offset: 0x00144E00
		public new static vtkPLinearExtrusionFilter New()
		{
			vtkPLinearExtrusionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLinearExtrusionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Create an object with PieceInvariant off.
		/// </summary>
		// Token: 0x0600EA50 RID: 59984 RVA: 0x00146C54 File Offset: 0x00144E54
		public vtkPLinearExtrusionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EA51 RID: 59985 RVA: 0x00146C98 File Offset: 0x00144E98
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EA52 RID: 59986
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPLinearExtrusionFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA53 RID: 59987 RVA: 0x00146CA4 File Offset: 0x00144EA4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600EA54 RID: 59988
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPLinearExtrusionFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA55 RID: 59989 RVA: 0x00146CC4 File Offset: 0x00144EC4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600EA56 RID: 59990
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLinearExtrusionFilter_GetPieceInvariant_03(HandleRef pThis);

		/// <summary>
		/// Create an object with PieceInvariant off.
		/// </summary>
		// Token: 0x0600EA57 RID: 59991 RVA: 0x00146CE0 File Offset: 0x00144EE0
		public virtual int GetPieceInvariant()
		{
			return vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_GetPieceInvariant_03(base.GetCppThis());
		}

		// Token: 0x0600EA58 RID: 59992
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLinearExtrusionFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA59 RID: 59993 RVA: 0x00146D00 File Offset: 0x00144F00
		public override int IsA(string type)
		{
			return vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600EA5A RID: 59994
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPLinearExtrusionFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA5B RID: 59995 RVA: 0x00146D20 File Offset: 0x00144F20
		public new static int IsTypeOf(string type)
		{
			return vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_IsTypeOf_05(type);
		}

		// Token: 0x0600EA5C RID: 59996
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLinearExtrusionFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA5D RID: 59997 RVA: 0x00146D3C File Offset: 0x00144F3C
		public new vtkPLinearExtrusionFilter NewInstance()
		{
			vtkPLinearExtrusionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPLinearExtrusionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EA5E RID: 59998
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLinearExtrusionFilter_PieceInvariantOff_08(HandleRef pThis);

		/// <summary>
		/// Create an object with PieceInvariant off.
		/// </summary>
		// Token: 0x0600EA5F RID: 59999 RVA: 0x00146D96 File Offset: 0x00144F96
		public virtual void PieceInvariantOff()
		{
			vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_PieceInvariantOff_08(base.GetCppThis());
		}

		// Token: 0x0600EA60 RID: 60000
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLinearExtrusionFilter_PieceInvariantOn_09(HandleRef pThis);

		/// <summary>
		/// Create an object with PieceInvariant off.
		/// </summary>
		// Token: 0x0600EA61 RID: 60001 RVA: 0x00146DA5 File Offset: 0x00144FA5
		public virtual void PieceInvariantOn()
		{
			vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_PieceInvariantOn_09(base.GetCppThis());
		}

		// Token: 0x0600EA62 RID: 60002
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPLinearExtrusionFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EA63 RID: 60003 RVA: 0x00146DB4 File Offset: 0x00144FB4
		public new static vtkPLinearExtrusionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPLinearExtrusionFilter vtkPLinearExtrusionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPLinearExtrusionFilter = (vtkPLinearExtrusionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPLinearExtrusionFilter.Register(null);
				}
			}
			return vtkPLinearExtrusionFilter;
		}

		// Token: 0x0600EA64 RID: 60004
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPLinearExtrusionFilter_SetPieceInvariant_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Create an object with PieceInvariant off.
		/// </summary>
		// Token: 0x0600EA65 RID: 60005 RVA: 0x00146E33 File Offset: 0x00145033
		public virtual void SetPieceInvariant(int _arg)
		{
			vtkPLinearExtrusionFilter.vtkPLinearExtrusionFilter_SetPieceInvariant_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001120 RID: 4384
		public new const string MRFullTypeName = "Kitware.VTK.vtkPLinearExtrusionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001121 RID: 4385
		public new static readonly string MRClassNameKey = "class vtkPLinearExtrusionFilter";
	}
}
