using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMassProperties
	/// </summary>
	/// <remarks>
	///    estimate volume, area, shape index of triangle mesh
	///
	/// vtkMassProperties estimates the volume, the surface area, and the
	/// normalized shape index of a triangle mesh.  The algorithm
	/// implemented here is based on the discrete form of the divergence
	/// theorem.  The general assumption here is that the model is of
	/// closed surface.  For more details see the following reference
	/// (Alyassin A.M. et al, "Evaluation of new algorithms for the
	/// interactive measurement of surface area and volume", Med Phys 21(6)
	/// 1994.).
	///
	/// @warning
	/// Currently only triangles are processed. Use vtkTriangleFilter to convert
	/// any strips or polygons to triangles. If multiple closed objects are
	/// defined consider using vtkMultiObjectMassProperties. Alternatively,
	/// vtkPolyDataConnectivityFilter can be used to extract connected regions
	/// (i.e., objects) one at a time, and then each object can be processed by
	/// this filter.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTriangleFilter vtkMultiObjectMassProperties
	/// </seealso>
	// Token: 0x0200097C RID: 2428
	public class vtkMassProperties : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060194C5 RID: 103621 RVA: 0x00233DB7 File Offset: 0x00231FB7
		static vtkMassProperties()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMassProperties.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMassProperties"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060194C6 RID: 103622 RVA: 0x00233DDF File Offset: 0x00231FDF
		public vtkMassProperties(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060194C7 RID: 103623
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMassProperties_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Constructs with initial values of zero.
		/// </summary>
		// Token: 0x060194C8 RID: 103624 RVA: 0x00233DF0 File Offset: 0x00231FF0
		public new static vtkMassProperties New()
		{
			vtkMassProperties result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMassProperties.vtkMassProperties_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMassProperties)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Constructs with initial values of zero.
		/// </summary>
		// Token: 0x060194C9 RID: 103625 RVA: 0x00233E44 File Offset: 0x00232044
		public vtkMassProperties() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMassProperties.vtkMassProperties_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060194CA RID: 103626 RVA: 0x00233E88 File Offset: 0x00232088
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060194CB RID: 103627
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMassProperties_GetKx_01(HandleRef pThis);

		/// <summary>
		/// Compute and return the weighting factors for the maximum unit
		/// normal component (MUNC).
		/// </summary>
		// Token: 0x060194CC RID: 103628 RVA: 0x00233E94 File Offset: 0x00232094
		public double GetKx()
		{
			return vtkMassProperties.vtkMassProperties_GetKx_01(base.GetCppThis());
		}

		// Token: 0x060194CD RID: 103629
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMassProperties_GetKy_02(HandleRef pThis);

		/// <summary>
		/// Compute and return the weighting factors for the maximum unit
		/// normal component (MUNC).
		/// </summary>
		// Token: 0x060194CE RID: 103630 RVA: 0x00233EB4 File Offset: 0x002320B4
		public double GetKy()
		{
			return vtkMassProperties.vtkMassProperties_GetKy_02(base.GetCppThis());
		}

		// Token: 0x060194CF RID: 103631
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMassProperties_GetKz_03(HandleRef pThis);

		/// <summary>
		/// Compute and return the weighting factors for the maximum unit
		/// normal component (MUNC).
		/// </summary>
		// Token: 0x060194D0 RID: 103632 RVA: 0x00233ED4 File Offset: 0x002320D4
		public double GetKz()
		{
			return vtkMassProperties.vtkMassProperties_GetKz_03(base.GetCppThis());
		}

		// Token: 0x060194D1 RID: 103633
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMassProperties_GetMaxCellArea_04(HandleRef pThis);

		/// <summary>
		/// Compute and return the max cell area.
		/// </summary>
		// Token: 0x060194D2 RID: 103634 RVA: 0x00233EF4 File Offset: 0x002320F4
		public double GetMaxCellArea()
		{
			return vtkMassProperties.vtkMassProperties_GetMaxCellArea_04(base.GetCppThis());
		}

		// Token: 0x060194D3 RID: 103635
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMassProperties_GetMinCellArea_05(HandleRef pThis);

		/// <summary>
		/// Compute and return the min cell area.
		/// </summary>
		// Token: 0x060194D4 RID: 103636 RVA: 0x00233F14 File Offset: 0x00232114
		public double GetMinCellArea()
		{
			return vtkMassProperties.vtkMassProperties_GetMinCellArea_05(base.GetCppThis());
		}

		// Token: 0x060194D5 RID: 103637
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMassProperties_GetNormalizedShapeIndex_06(HandleRef pThis);

		/// <summary>
		/// Compute and return the normalized shape index. This characterizes the
		/// deviation of the shape of an object from a sphere. A sphere's NSI
		/// is one. This number is always &gt;= 1.0.
		/// </summary>
		// Token: 0x060194D6 RID: 103638 RVA: 0x00233F34 File Offset: 0x00232134
		public double GetNormalizedShapeIndex()
		{
			return vtkMassProperties.vtkMassProperties_GetNormalizedShapeIndex_06(base.GetCppThis());
		}

		// Token: 0x060194D7 RID: 103639
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMassProperties_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Constructs with initial values of zero.
		/// </summary>
		// Token: 0x060194D8 RID: 103640 RVA: 0x00233F54 File Offset: 0x00232154
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMassProperties.vtkMassProperties_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x060194D9 RID: 103641
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMassProperties_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Constructs with initial values of zero.
		/// </summary>
		// Token: 0x060194DA RID: 103642 RVA: 0x00233F74 File Offset: 0x00232174
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMassProperties.vtkMassProperties_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x060194DB RID: 103643
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMassProperties_GetSurfaceArea_09(HandleRef pThis);

		/// <summary>
		/// Compute and return the area.
		/// </summary>
		// Token: 0x060194DC RID: 103644 RVA: 0x00233F90 File Offset: 0x00232190
		public double GetSurfaceArea()
		{
			return vtkMassProperties.vtkMassProperties_GetSurfaceArea_09(base.GetCppThis());
		}

		// Token: 0x060194DD RID: 103645
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMassProperties_GetVolume_10(HandleRef pThis);

		/// <summary>
		/// Compute and return the volume.
		/// </summary>
		// Token: 0x060194DE RID: 103646 RVA: 0x00233FB0 File Offset: 0x002321B0
		public double GetVolume()
		{
			return vtkMassProperties.vtkMassProperties_GetVolume_10(base.GetCppThis());
		}

		// Token: 0x060194DF RID: 103647
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMassProperties_GetVolumeProjected_11(HandleRef pThis);

		/// <summary>
		/// Compute and return the projected volume.
		/// Typically you should compare this volume to the value returned by GetVolume
		/// if you get an error (GetVolume()-GetVolumeProjected())*10000 that is greater
		/// than GetVolume() this should identify a problem:
		/// * Either the polydata is not closed
		/// * Or the polydata contains triangle that are flipped
		/// </summary>
		// Token: 0x060194E0 RID: 103648 RVA: 0x00233FD0 File Offset: 0x002321D0
		public double GetVolumeProjected()
		{
			return vtkMassProperties.vtkMassProperties_GetVolumeProjected_11(base.GetCppThis());
		}

		// Token: 0x060194E1 RID: 103649
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMassProperties_GetVolumeX_12(HandleRef pThis);

		/// <summary>
		/// Compute and return the volume projected on to each axis aligned plane.
		/// </summary>
		// Token: 0x060194E2 RID: 103650 RVA: 0x00233FF0 File Offset: 0x002321F0
		public double GetVolumeX()
		{
			return vtkMassProperties.vtkMassProperties_GetVolumeX_12(base.GetCppThis());
		}

		// Token: 0x060194E3 RID: 103651
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMassProperties_GetVolumeY_13(HandleRef pThis);

		/// <summary>
		/// Compute and return the volume projected on to each axis aligned plane.
		/// </summary>
		// Token: 0x060194E4 RID: 103652 RVA: 0x00234010 File Offset: 0x00232210
		public double GetVolumeY()
		{
			return vtkMassProperties.vtkMassProperties_GetVolumeY_13(base.GetCppThis());
		}

		// Token: 0x060194E5 RID: 103653
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkMassProperties_GetVolumeZ_14(HandleRef pThis);

		/// <summary>
		/// Compute and return the volume projected on to each axis aligned plane.
		/// </summary>
		// Token: 0x060194E6 RID: 103654 RVA: 0x00234030 File Offset: 0x00232230
		public double GetVolumeZ()
		{
			return vtkMassProperties.vtkMassProperties_GetVolumeZ_14(base.GetCppThis());
		}

		// Token: 0x060194E7 RID: 103655
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMassProperties_IsA_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Constructs with initial values of zero.
		/// </summary>
		// Token: 0x060194E8 RID: 103656 RVA: 0x00234050 File Offset: 0x00232250
		public override int IsA(string type)
		{
			return vtkMassProperties.vtkMassProperties_IsA_15(base.GetCppThis(), type);
		}

		// Token: 0x060194E9 RID: 103657
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMassProperties_IsTypeOf_16([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Constructs with initial values of zero.
		/// </summary>
		// Token: 0x060194EA RID: 103658 RVA: 0x00234070 File Offset: 0x00232270
		public new static int IsTypeOf(string type)
		{
			return vtkMassProperties.vtkMassProperties_IsTypeOf_16(type);
		}

		// Token: 0x060194EB RID: 103659
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMassProperties_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Constructs with initial values of zero.
		/// </summary>
		// Token: 0x060194EC RID: 103660 RVA: 0x0023408C File Offset: 0x0023228C
		public new vtkMassProperties NewInstance()
		{
			vtkMassProperties result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMassProperties.vtkMassProperties_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMassProperties)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060194ED RID: 103661
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMassProperties_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Constructs with initial values of zero.
		/// </summary>
		// Token: 0x060194EE RID: 103662 RVA: 0x002340E8 File Offset: 0x002322E8
		public new static vtkMassProperties SafeDownCast(vtkObjectBase o)
		{
			vtkMassProperties vtkMassProperties = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMassProperties.vtkMassProperties_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMassProperties = (vtkMassProperties)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMassProperties.Register(null);
				}
			}
			return vtkMassProperties;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BB4 RID: 7092
		public new const string MRFullTypeName = "Kitware.VTK.vtkMassProperties";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BB5 RID: 7093
		public new static readonly string MRClassNameKey = "class vtkMassProperties";
	}
}
