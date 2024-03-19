using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkEdgePoints
	/// </summary>
	/// <remarks>
	///    generate points on isosurface
	///
	/// vtkEdgePoints is a filter that takes as input any dataset and
	/// generates for output a set of points that lie on an isosurface. The
	/// points are created by interpolation along cells edges whose end-points are
	/// below and above the contour value.
	/// @warning
	/// vtkEdgePoints can be considered a "poor man's" dividing cubes algorithm
	/// (see vtkDividingCubes). Points are generated only on the edges of cells,
	/// not in the interior, and at lower density than dividing cubes. However, it
	/// is more general than dividing cubes since it treats any type of dataset.
	/// </remarks>
	// Token: 0x0200089A RID: 2202
	public class vtkEdgePoints : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016E01 RID: 93697 RVA: 0x0020249D File Offset: 0x0020069D
		static vtkEdgePoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEdgePoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgePoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016E02 RID: 93698 RVA: 0x002024C5 File Offset: 0x002006C5
		public vtkEdgePoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016E03 RID: 93699
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgePoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with contour value of 0.0.
		/// </summary>
		// Token: 0x06016E04 RID: 93700 RVA: 0x002024D4 File Offset: 0x002006D4
		public new static vtkEdgePoints New()
		{
			vtkEdgePoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgePoints.vtkEdgePoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgePoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with contour value of 0.0.
		/// </summary>
		// Token: 0x06016E05 RID: 93701 RVA: 0x00202528 File Offset: 0x00200728
		public vtkEdgePoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkEdgePoints.vtkEdgePoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016E06 RID: 93702 RVA: 0x0020256C File Offset: 0x0020076C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016E07 RID: 93703
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgePoints_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E08 RID: 93704 RVA: 0x00202578 File Offset: 0x00200778
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkEdgePoints.vtkEdgePoints_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016E09 RID: 93705
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkEdgePoints_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E0A RID: 93706 RVA: 0x00202598 File Offset: 0x00200798
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkEdgePoints.vtkEdgePoints_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016E0B RID: 93707
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkEdgePoints_GetValue_03(HandleRef pThis);

		/// <summary>
		/// Set/get the contour value.
		/// </summary>
		// Token: 0x06016E0C RID: 93708 RVA: 0x002025B4 File Offset: 0x002007B4
		public virtual double GetValue()
		{
			return vtkEdgePoints.vtkEdgePoints_GetValue_03(base.GetCppThis());
		}

		// Token: 0x06016E0D RID: 93709
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgePoints_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E0E RID: 93710 RVA: 0x002025D4 File Offset: 0x002007D4
		public override int IsA(string type)
		{
			return vtkEdgePoints.vtkEdgePoints_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06016E0F RID: 93711
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkEdgePoints_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E10 RID: 93712 RVA: 0x002025F4 File Offset: 0x002007F4
		public new static int IsTypeOf(string type)
		{
			return vtkEdgePoints.vtkEdgePoints_IsTypeOf_05(type);
		}

		// Token: 0x06016E11 RID: 93713
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgePoints_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E12 RID: 93714 RVA: 0x00202610 File Offset: 0x00200810
		public new vtkEdgePoints NewInstance()
		{
			vtkEdgePoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgePoints.vtkEdgePoints_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEdgePoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016E13 RID: 93715
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkEdgePoints_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E14 RID: 93716 RVA: 0x0020266C File Offset: 0x0020086C
		public new static vtkEdgePoints SafeDownCast(vtkObjectBase o)
		{
			vtkEdgePoints vtkEdgePoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkEdgePoints.vtkEdgePoints_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEdgePoints = (vtkEdgePoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEdgePoints.Register(null);
				}
			}
			return vtkEdgePoints;
		}

		// Token: 0x06016E15 RID: 93717
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkEdgePoints_SetValue_09(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/get the contour value.
		/// </summary>
		// Token: 0x06016E16 RID: 93718 RVA: 0x002026EB File Offset: 0x002008EB
		public virtual void SetValue(double _arg)
		{
			vtkEdgePoints.vtkEdgePoints_SetValue_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001995 RID: 6549
		public new const string MRFullTypeName = "Kitware.VTK.vtkEdgePoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001996 RID: 6550
		public new static readonly string MRClassNameKey = "class vtkEdgePoints";
	}
}
