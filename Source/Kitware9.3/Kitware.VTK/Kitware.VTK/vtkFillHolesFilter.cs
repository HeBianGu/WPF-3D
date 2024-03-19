using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFillHolesFilter
	/// </summary>
	/// <remarks>
	///    identify and fill holes in meshes
	///
	/// vtkFillHolesFilter is a filter that identifies and fills holes in
	/// input vtkPolyData meshes. Holes are identified by locating
	/// boundary edges, linking them together into loops, and then
	/// triangulating the resulting loops. Note that you can specify
	/// an approximate limit to the size of the hole that can be filled.
	///
	/// @warning
	/// Note that any mesh with boundary edges by definition has a
	/// topological hole. This even includes a reactangular grid
	/// (e.g., the output of vtkPlaneSource). In such situations, if
	/// the outer hole is filled, retriangulation of the hole will cause
	/// geometric overlap of the mesh. This can be prevented by using
	/// the hole size instance variable to prevent the larger holes
	/// from being triangulated.
	///
	/// @warning
	/// Note this filter only operates on polygons and triangle strips.
	/// Vertices and polylines are passed through untouched.
	/// </remarks>
	// Token: 0x02000554 RID: 1364
	public class vtkFillHolesFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F28F RID: 62095 RVA: 0x00151EC3 File Offset: 0x001500C3
		static vtkFillHolesFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFillHolesFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFillHolesFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F290 RID: 62096 RVA: 0x00151EEB File Offset: 0x001500EB
		public vtkFillHolesFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F291 RID: 62097
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFillHolesFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600F292 RID: 62098 RVA: 0x00151EFC File Offset: 0x001500FC
		public new static vtkFillHolesFilter New()
		{
			vtkFillHolesFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFillHolesFilter.vtkFillHolesFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFillHolesFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600F293 RID: 62099 RVA: 0x00151F50 File Offset: 0x00150150
		public vtkFillHolesFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFillHolesFilter.vtkFillHolesFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F294 RID: 62100 RVA: 0x00151F94 File Offset: 0x00150194
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F295 RID: 62101
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFillHolesFilter_GetHoleSize_01(HandleRef pThis);

		/// <summary>
		/// Specify the maximum hole size to fill. This is represented as a radius
		/// to the bounding circumsphere containing the hole.  Note that this is an
		/// approximate area; the actual area cannot be computed without first
		/// triangulating the hole.
		/// </summary>
		// Token: 0x0600F296 RID: 62102 RVA: 0x00151FA0 File Offset: 0x001501A0
		public virtual double GetHoleSize()
		{
			return vtkFillHolesFilter.vtkFillHolesFilter_GetHoleSize_01(base.GetCppThis());
		}

		// Token: 0x0600F297 RID: 62103
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFillHolesFilter_GetHoleSizeMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Specify the maximum hole size to fill. This is represented as a radius
		/// to the bounding circumsphere containing the hole.  Note that this is an
		/// approximate area; the actual area cannot be computed without first
		/// triangulating the hole.
		/// </summary>
		// Token: 0x0600F298 RID: 62104 RVA: 0x00151FC0 File Offset: 0x001501C0
		public virtual double GetHoleSizeMaxValue()
		{
			return vtkFillHolesFilter.vtkFillHolesFilter_GetHoleSizeMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0600F299 RID: 62105
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkFillHolesFilter_GetHoleSizeMinValue_03(HandleRef pThis);

		/// <summary>
		/// Specify the maximum hole size to fill. This is represented as a radius
		/// to the bounding circumsphere containing the hole.  Note that this is an
		/// approximate area; the actual area cannot be computed without first
		/// triangulating the hole.
		/// </summary>
		// Token: 0x0600F29A RID: 62106 RVA: 0x00151FE0 File Offset: 0x001501E0
		public virtual double GetHoleSizeMinValue()
		{
			return vtkFillHolesFilter.vtkFillHolesFilter_GetHoleSizeMinValue_03(base.GetCppThis());
		}

		// Token: 0x0600F29B RID: 62107
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFillHolesFilter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600F29C RID: 62108 RVA: 0x00152000 File Offset: 0x00150200
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFillHolesFilter.vtkFillHolesFilter_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600F29D RID: 62109
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFillHolesFilter_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600F29E RID: 62110 RVA: 0x00152020 File Offset: 0x00150220
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFillHolesFilter.vtkFillHolesFilter_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600F29F RID: 62111
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFillHolesFilter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600F2A0 RID: 62112 RVA: 0x0015203C File Offset: 0x0015023C
		public override int IsA(string type)
		{
			return vtkFillHolesFilter.vtkFillHolesFilter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600F2A1 RID: 62113
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFillHolesFilter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600F2A2 RID: 62114 RVA: 0x0015205C File Offset: 0x0015025C
		public new static int IsTypeOf(string type)
		{
			return vtkFillHolesFilter.vtkFillHolesFilter_IsTypeOf_07(type);
		}

		// Token: 0x0600F2A3 RID: 62115
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFillHolesFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600F2A4 RID: 62116 RVA: 0x00152078 File Offset: 0x00150278
		public new vtkFillHolesFilter NewInstance()
		{
			vtkFillHolesFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFillHolesFilter.vtkFillHolesFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFillHolesFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F2A5 RID: 62117
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFillHolesFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, type information and printing.
		/// </summary>
		// Token: 0x0600F2A6 RID: 62118 RVA: 0x001520D4 File Offset: 0x001502D4
		public new static vtkFillHolesFilter SafeDownCast(vtkObjectBase o)
		{
			vtkFillHolesFilter vtkFillHolesFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFillHolesFilter.vtkFillHolesFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFillHolesFilter = (vtkFillHolesFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFillHolesFilter.Register(null);
				}
			}
			return vtkFillHolesFilter;
		}

		// Token: 0x0600F2A7 RID: 62119
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFillHolesFilter_SetHoleSize_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the maximum hole size to fill. This is represented as a radius
		/// to the bounding circumsphere containing the hole.  Note that this is an
		/// approximate area; the actual area cannot be computed without first
		/// triangulating the hole.
		/// </summary>
		// Token: 0x0600F2A8 RID: 62120 RVA: 0x00152153 File Offset: 0x00150353
		public virtual void SetHoleSize(double _arg)
		{
			vtkFillHolesFilter.vtkFillHolesFilter_SetHoleSize_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011A3 RID: 4515
		public new const string MRFullTypeName = "Kitware.VTK.vtkFillHolesFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011A4 RID: 4516
		public new static readonly string MRClassNameKey = "class vtkFillHolesFilter";
	}
}
