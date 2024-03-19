using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <remarks>
	///   Compute Hausdorff distance between two point sets
	///
	/// This class computes the relative and hausdorff distances from two point
	/// sets (input port 0 and input port 1). If no topology is specified (ie.
	/// vtkPointSet or vtkPolyData without vtkPolys), the distances are
	/// computed between point location. If polys exist (ie triangulation),
	/// the TargetDistanceMethod allows for an interpolation of the cells to
	/// ensure a better minimal distance exploration.
	///
	/// The outputs (port 0 and 1) have the same geometry and topology as its
	/// respective input port. Two FieldData arrays are added : HausdorffDistance
	/// and RelativeDistance. The former is equal on both outputs whereas the
	/// latter may differ. A PointData containing the specific point minimal
	/// distance is also added to both outputs.
	///
	/// @author Frederic Commandeur
	/// @author Jerome Velut
	/// @author LTSI
	///
	/// @see https://www.vtkjournal.org/browse/publication/839
	/// </remarks>
	// Token: 0x02000557 RID: 1367
	public class vtkHausdorffDistancePointSetFilter : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F2DD RID: 62173 RVA: 0x001525D1 File Offset: 0x001507D1
		static vtkHausdorffDistancePointSetFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHausdorffDistancePointSetFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHausdorffDistancePointSetFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F2DE RID: 62174 RVA: 0x001525F9 File Offset: 0x001507F9
		public vtkHausdorffDistancePointSetFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F2DF RID: 62175
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHausdorffDistancePointSetFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2E0 RID: 62176 RVA: 0x00152608 File Offset: 0x00150808
		public new static vtkHausdorffDistancePointSetFilter New()
		{
			vtkHausdorffDistancePointSetFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHausdorffDistancePointSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2E1 RID: 62177 RVA: 0x0015265C File Offset: 0x0015085C
		public vtkHausdorffDistancePointSetFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F2E2 RID: 62178 RVA: 0x001526A0 File Offset: 0x001508A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F2E3 RID: 62179
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHausdorffDistancePointSetFilter_GetHausdorffDistance_01(HandleRef pThis);

		/// <summary>
		/// Get the Hausdorff Distance.
		/// </summary>
		// Token: 0x0600F2E4 RID: 62180 RVA: 0x001526AC File Offset: 0x001508AC
		public virtual double GetHausdorffDistance()
		{
			return vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_GetHausdorffDistance_01(base.GetCppThis());
		}

		// Token: 0x0600F2E5 RID: 62181
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHausdorffDistancePointSetFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2E6 RID: 62182 RVA: 0x001526CC File Offset: 0x001508CC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600F2E7 RID: 62183
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHausdorffDistancePointSetFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2E8 RID: 62184 RVA: 0x001526EC File Offset: 0x001508EC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600F2E9 RID: 62185
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHausdorffDistancePointSetFilter_GetRelativeDistance_04(HandleRef pThis);

		/// <summary>
		/// Get the Relative Distance from A to B and B to A.
		/// </summary>
		// Token: 0x0600F2EA RID: 62186 RVA: 0x00152708 File Offset: 0x00150908
		public virtual double[] GetRelativeDistance()
		{
			IntPtr intPtr = vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_GetRelativeDistance_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600F2EB RID: 62187
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHausdorffDistancePointSetFilter_GetRelativeDistance_05(HandleRef pThis, ref double _arg1, ref double _arg2);

		/// <summary>
		/// Get the Relative Distance from A to B and B to A.
		/// </summary>
		// Token: 0x0600F2EC RID: 62188 RVA: 0x00152750 File Offset: 0x00150950
		public virtual void GetRelativeDistance(ref double _arg1, ref double _arg2)
		{
			vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_GetRelativeDistance_05(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600F2ED RID: 62189
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHausdorffDistancePointSetFilter_GetRelativeDistance_06(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the Relative Distance from A to B and B to A.
		/// </summary>
		// Token: 0x0600F2EE RID: 62190 RVA: 0x00152761 File Offset: 0x00150961
		public virtual void GetRelativeDistance(IntPtr _arg)
		{
			vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_GetRelativeDistance_06(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F2EF RID: 62191
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHausdorffDistancePointSetFilter_GetTargetDistanceMethod_07(HandleRef pThis);

		/// <summary>
		/// Specify the strategy for computing the distance. If no topology is specified (ie.
		/// vtkPointSet or vtkPolyData without vtkPolys), the distances are
		/// computed between point location. If polys exist (i.e. triangulation),
		/// the TargetDistanceMethod allows for an interpolation of the cells to
		/// ensure a better minimal distance exploration.
		///
		/// </summary>
		// Token: 0x0600F2F0 RID: 62192 RVA: 0x00152774 File Offset: 0x00150974
		public virtual int GetTargetDistanceMethod()
		{
			return vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_GetTargetDistanceMethod_07(base.GetCppThis());
		}

		// Token: 0x0600F2F1 RID: 62193
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHausdorffDistancePointSetFilter_GetTargetDistanceMethodAsString_08(HandleRef pThis);

		/// <summary>
		/// Specify the strategy for computing the distance. If no topology is specified (ie.
		/// vtkPointSet or vtkPolyData without vtkPolys), the distances are
		/// computed between point location. If polys exist (i.e. triangulation),
		/// the TargetDistanceMethod allows for an interpolation of the cells to
		/// ensure a better minimal distance exploration.
		///
		/// </summary>
		// Token: 0x0600F2F2 RID: 62194 RVA: 0x00152794 File Offset: 0x00150994
		public string GetTargetDistanceMethodAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_GetTargetDistanceMethodAsString_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600F2F3 RID: 62195
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHausdorffDistancePointSetFilter_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2F4 RID: 62196 RVA: 0x001527D0 File Offset: 0x001509D0
		public override int IsA(string type)
		{
			return vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0600F2F5 RID: 62197
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHausdorffDistancePointSetFilter_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2F6 RID: 62198 RVA: 0x001527F0 File Offset: 0x001509F0
		public new static int IsTypeOf(string type)
		{
			return vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_IsTypeOf_10(type);
		}

		// Token: 0x0600F2F7 RID: 62199
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHausdorffDistancePointSetFilter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2F8 RID: 62200 RVA: 0x0015280C File Offset: 0x00150A0C
		public new vtkHausdorffDistancePointSetFilter NewInstance()
		{
			vtkHausdorffDistancePointSetFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHausdorffDistancePointSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F2F9 RID: 62201
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHausdorffDistancePointSetFilter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for construction, type and printing.
		/// </summary>
		// Token: 0x0600F2FA RID: 62202 RVA: 0x00152868 File Offset: 0x00150A68
		public new static vtkHausdorffDistancePointSetFilter SafeDownCast(vtkObjectBase o)
		{
			vtkHausdorffDistancePointSetFilter vtkHausdorffDistancePointSetFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHausdorffDistancePointSetFilter = (vtkHausdorffDistancePointSetFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHausdorffDistancePointSetFilter.Register(null);
				}
			}
			return vtkHausdorffDistancePointSetFilter;
		}

		// Token: 0x0600F2FB RID: 62203
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHausdorffDistancePointSetFilter_SetTargetDistanceMethod_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the strategy for computing the distance. If no topology is specified (ie.
		/// vtkPointSet or vtkPolyData without vtkPolys), the distances are
		/// computed between point location. If polys exist (i.e. triangulation),
		/// the TargetDistanceMethod allows for an interpolation of the cells to
		/// ensure a better minimal distance exploration.
		///
		/// </summary>
		// Token: 0x0600F2FC RID: 62204 RVA: 0x001528E7 File Offset: 0x00150AE7
		public virtual void SetTargetDistanceMethod(int _arg)
		{
			vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_SetTargetDistanceMethod_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600F2FD RID: 62205
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHausdorffDistancePointSetFilter_SetTargetDistanceMethodToPointToCell_15(HandleRef pThis);

		/// <summary>
		/// Specify the strategy for computing the distance. If no topology is specified (ie.
		/// vtkPointSet or vtkPolyData without vtkPolys), the distances are
		/// computed between point location. If polys exist (i.e. triangulation),
		/// the TargetDistanceMethod allows for an interpolation of the cells to
		/// ensure a better minimal distance exploration.
		///
		/// </summary>
		// Token: 0x0600F2FE RID: 62206 RVA: 0x001528F7 File Offset: 0x00150AF7
		public void SetTargetDistanceMethodToPointToCell()
		{
			vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_SetTargetDistanceMethodToPointToCell_15(base.GetCppThis());
		}

		// Token: 0x0600F2FF RID: 62207
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHausdorffDistancePointSetFilter_SetTargetDistanceMethodToPointToPoint_16(HandleRef pThis);

		/// <summary>
		/// Specify the strategy for computing the distance. If no topology is specified (ie.
		/// vtkPointSet or vtkPolyData without vtkPolys), the distances are
		/// computed between point location. If polys exist (i.e. triangulation),
		/// the TargetDistanceMethod allows for an interpolation of the cells to
		/// ensure a better minimal distance exploration.
		///
		/// </summary>
		// Token: 0x0600F300 RID: 62208 RVA: 0x00152906 File Offset: 0x00150B06
		public void SetTargetDistanceMethodToPointToPoint()
		{
			vtkHausdorffDistancePointSetFilter.vtkHausdorffDistancePointSetFilter_SetTargetDistanceMethodToPointToPoint_16(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011AF RID: 4527
		public new const string MRFullTypeName = "Kitware.VTK.vtkHausdorffDistancePointSetFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011B0 RID: 4528
		public new static readonly string MRClassNameKey = "class vtkHausdorffDistancePointSetFilter";

		/// <summary>
		/// Get the Hausdorff Distance.
		/// </summary>
		// Token: 0x02000558 RID: 1368
		public enum DistanceMethod
		{
			/// <summary>enum member</summary>
			// Token: 0x040011B2 RID: 4530
			POINT_TO_CELL = 1,
			/// <summary>enum member</summary>
			// Token: 0x040011B3 RID: 4531
			POINT_TO_POINT = 0
		}
	}
}
