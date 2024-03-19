using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkApproximatingSubdivisionFilter
	/// </summary>
	/// <remarks>
	///    generate a subdivision surface using an Approximating Scheme
	///
	/// vtkApproximatingSubdivisionFilter is an abstract class that defines
	/// the protocol for Approximating subdivision surface filters.
	///
	/// @par Thanks:
	/// This work was supported by PHS Research Grant No. 1 P41 RR13218-01
	/// from the National Center for Research Resources.
	/// </remarks>
	// Token: 0x02000561 RID: 1377
	public abstract class vtkApproximatingSubdivisionFilter : vtkSubdivisionFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F3F9 RID: 62457 RVA: 0x00153C77 File Offset: 0x00151E77
		static vtkApproximatingSubdivisionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkApproximatingSubdivisionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkApproximatingSubdivisionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F3FA RID: 62458 RVA: 0x00153C9F File Offset: 0x00151E9F
		public vtkApproximatingSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F3FB RID: 62459 RVA: 0x00153CAD File Offset: 0x00151EAD
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F3FC RID: 62460
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkApproximatingSubdivisionFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F3FD RID: 62461 RVA: 0x00153CB8 File Offset: 0x00151EB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkApproximatingSubdivisionFilter.vtkApproximatingSubdivisionFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600F3FE RID: 62462
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkApproximatingSubdivisionFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F3FF RID: 62463 RVA: 0x00153CD8 File Offset: 0x00151ED8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkApproximatingSubdivisionFilter.vtkApproximatingSubdivisionFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600F400 RID: 62464
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkApproximatingSubdivisionFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F401 RID: 62465 RVA: 0x00153CF4 File Offset: 0x00151EF4
		public override int IsA(string type)
		{
			return vtkApproximatingSubdivisionFilter.vtkApproximatingSubdivisionFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600F402 RID: 62466
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkApproximatingSubdivisionFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F403 RID: 62467 RVA: 0x00153D14 File Offset: 0x00151F14
		public new static int IsTypeOf(string type)
		{
			return vtkApproximatingSubdivisionFilter.vtkApproximatingSubdivisionFilter_IsTypeOf_04(type);
		}

		// Token: 0x0600F404 RID: 62468
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApproximatingSubdivisionFilter_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F405 RID: 62469 RVA: 0x00153D30 File Offset: 0x00151F30
		public new vtkApproximatingSubdivisionFilter NewInstance()
		{
			vtkApproximatingSubdivisionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkApproximatingSubdivisionFilter.vtkApproximatingSubdivisionFilter_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkApproximatingSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F406 RID: 62470
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkApproximatingSubdivisionFilter_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F407 RID: 62471 RVA: 0x00153D8C File Offset: 0x00151F8C
		public new static vtkApproximatingSubdivisionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkApproximatingSubdivisionFilter vtkApproximatingSubdivisionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkApproximatingSubdivisionFilter.vtkApproximatingSubdivisionFilter_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkApproximatingSubdivisionFilter = (vtkApproximatingSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkApproximatingSubdivisionFilter.Register(null);
				}
			}
			return vtkApproximatingSubdivisionFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011CD RID: 4557
		public new const string MRFullTypeName = "Kitware.VTK.vtkApproximatingSubdivisionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011CE RID: 4558
		public new static readonly string MRClassNameKey = "class vtkApproximatingSubdivisionFilter";
	}
}
