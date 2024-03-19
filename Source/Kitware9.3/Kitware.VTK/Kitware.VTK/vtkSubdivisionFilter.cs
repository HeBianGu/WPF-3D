using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSubdivisionFilter
	/// </summary>
	/// <remarks>
	///    base class for subvision filters
	///
	/// vtkSubdivisionFilter is an abstract class that defines
	/// the protocol for subdivision surface filters.
	///
	/// </remarks>
	// Token: 0x02000548 RID: 1352
	public class vtkSubdivisionFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F0E7 RID: 61671 RVA: 0x0014F9EE File Offset: 0x0014DBEE
		static vtkSubdivisionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSubdivisionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSubdivisionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F0E8 RID: 61672 RVA: 0x0014FA16 File Offset: 0x0014DC16
		public vtkSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F0E9 RID: 61673 RVA: 0x0014FA24 File Offset: 0x0014DC24
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F0EA RID: 61674
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSubdivisionFilter_CheckForTrianglesOff_01(HandleRef pThis);

		/// <summary>
		/// Set/get CheckForTriangles
		/// Should subdivision check that the dataset only contains triangles?
		/// Default is On (1).
		/// </summary>
		// Token: 0x0600F0EB RID: 61675 RVA: 0x0014FA2F File Offset: 0x0014DC2F
		public virtual void CheckForTrianglesOff()
		{
			vtkSubdivisionFilter.vtkSubdivisionFilter_CheckForTrianglesOff_01(base.GetCppThis());
		}

		// Token: 0x0600F0EC RID: 61676
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSubdivisionFilter_CheckForTrianglesOn_02(HandleRef pThis);

		/// <summary>
		/// Set/get CheckForTriangles
		/// Should subdivision check that the dataset only contains triangles?
		/// Default is On (1).
		/// </summary>
		// Token: 0x0600F0ED RID: 61677 RVA: 0x0014FA3E File Offset: 0x0014DC3E
		public virtual void CheckForTrianglesOn()
		{
			vtkSubdivisionFilter.vtkSubdivisionFilter_CheckForTrianglesOn_02(base.GetCppThis());
		}

		// Token: 0x0600F0EE RID: 61678
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubdivisionFilter_GetCheckForTriangles_03(HandleRef pThis);

		/// <summary>
		/// Set/get CheckForTriangles
		/// Should subdivision check that the dataset only contains triangles?
		/// Default is On (1).
		/// </summary>
		// Token: 0x0600F0EF RID: 61679 RVA: 0x0014FA50 File Offset: 0x0014DC50
		public virtual int GetCheckForTriangles()
		{
			return vtkSubdivisionFilter.vtkSubdivisionFilter_GetCheckForTriangles_03(base.GetCppThis());
		}

		// Token: 0x0600F0F0 RID: 61680
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubdivisionFilter_GetCheckForTrianglesMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set/get CheckForTriangles
		/// Should subdivision check that the dataset only contains triangles?
		/// Default is On (1).
		/// </summary>
		// Token: 0x0600F0F1 RID: 61681 RVA: 0x0014FA70 File Offset: 0x0014DC70
		public virtual int GetCheckForTrianglesMaxValue()
		{
			return vtkSubdivisionFilter.vtkSubdivisionFilter_GetCheckForTrianglesMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0600F0F2 RID: 61682
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubdivisionFilter_GetCheckForTrianglesMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set/get CheckForTriangles
		/// Should subdivision check that the dataset only contains triangles?
		/// Default is On (1).
		/// </summary>
		// Token: 0x0600F0F3 RID: 61683 RVA: 0x0014FA90 File Offset: 0x0014DC90
		public virtual int GetCheckForTrianglesMinValue()
		{
			return vtkSubdivisionFilter.vtkSubdivisionFilter_GetCheckForTrianglesMinValue_05(base.GetCppThis());
		}

		// Token: 0x0600F0F4 RID: 61684
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSubdivisionFilter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F0F5 RID: 61685 RVA: 0x0014FAB0 File Offset: 0x0014DCB0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSubdivisionFilter.vtkSubdivisionFilter_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0600F0F6 RID: 61686
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSubdivisionFilter_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F0F7 RID: 61687 RVA: 0x0014FAD0 File Offset: 0x0014DCD0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSubdivisionFilter.vtkSubdivisionFilter_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0600F0F8 RID: 61688
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubdivisionFilter_GetNumberOfSubdivisions_08(HandleRef pThis);

		/// <summary>
		/// Set/get the number of subdivisions.
		/// Default is 1.
		/// </summary>
		// Token: 0x0600F0F9 RID: 61689 RVA: 0x0014FAEC File Offset: 0x0014DCEC
		public virtual int GetNumberOfSubdivisions()
		{
			return vtkSubdivisionFilter.vtkSubdivisionFilter_GetNumberOfSubdivisions_08(base.GetCppThis());
		}

		// Token: 0x0600F0FA RID: 61690
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubdivisionFilter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F0FB RID: 61691 RVA: 0x0014FB0C File Offset: 0x0014DD0C
		public override int IsA(string type)
		{
			return vtkSubdivisionFilter.vtkSubdivisionFilter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600F0FC RID: 61692
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubdivisionFilter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F0FD RID: 61693 RVA: 0x0014FB2C File Offset: 0x0014DD2C
		public new static int IsTypeOf(string type)
		{
			return vtkSubdivisionFilter.vtkSubdivisionFilter_IsTypeOf_10(type);
		}

		// Token: 0x0600F0FE RID: 61694
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubdivisionFilter_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F0FF RID: 61695 RVA: 0x0014FB48 File Offset: 0x0014DD48
		public new vtkSubdivisionFilter NewInstance()
		{
			vtkSubdivisionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubdivisionFilter.vtkSubdivisionFilter_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F100 RID: 61696
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubdivisionFilter_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F101 RID: 61697 RVA: 0x0014FBA4 File Offset: 0x0014DDA4
		public new static vtkSubdivisionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSubdivisionFilter vtkSubdivisionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubdivisionFilter.vtkSubdivisionFilter_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSubdivisionFilter = (vtkSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSubdivisionFilter.Register(null);
				}
			}
			return vtkSubdivisionFilter;
		}

		// Token: 0x0600F102 RID: 61698
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSubdivisionFilter_SetCheckForTriangles_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get CheckForTriangles
		/// Should subdivision check that the dataset only contains triangles?
		/// Default is On (1).
		/// </summary>
		// Token: 0x0600F103 RID: 61699 RVA: 0x0014FC23 File Offset: 0x0014DE23
		public virtual void SetCheckForTriangles(int _arg)
		{
			vtkSubdivisionFilter.vtkSubdivisionFilter_SetCheckForTriangles_13(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F104 RID: 61700
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSubdivisionFilter_SetNumberOfSubdivisions_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the number of subdivisions.
		/// Default is 1.
		/// </summary>
		// Token: 0x0600F105 RID: 61701 RVA: 0x0014FC33 File Offset: 0x0014DE33
		public virtual void SetNumberOfSubdivisions(int _arg)
		{
			vtkSubdivisionFilter.vtkSubdivisionFilter_SetNumberOfSubdivisions_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001188 RID: 4488
		public new const string MRFullTypeName = "Kitware.VTK.vtkSubdivisionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001189 RID: 4489
		public new static readonly string MRClassNameKey = "class vtkSubdivisionFilter";
	}
}
