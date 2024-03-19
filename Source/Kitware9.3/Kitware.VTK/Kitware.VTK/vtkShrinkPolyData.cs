using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkShrinkPolyData
	/// </summary>
	/// <remarks>
	///    shrink cells composing PolyData
	///
	/// vtkShrinkPolyData shrinks cells composing a polygonal dataset (e.g.,
	/// vertices, lines, polygons, and triangle strips) towards their centroid.
	/// The centroid of a cell is computed as the average position of the
	/// cell points. Shrinking results in disconnecting the cells from
	/// one another. The output dataset type of this filter is polygonal data.
	///
	/// During execution the filter passes its input cell data to its
	/// output. Point data attributes are copied to the points created during the
	/// shrinking process.
	///
	/// @warning
	/// It is possible to turn cells inside out or cause self intersection
	/// in special cases.
	/// Users should use the vtkTriangleFilter to triangulate meshes that
	/// contain triangle strips.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkShrinkFilter
	/// </seealso>
	// Token: 0x020008DD RID: 2269
	public class vtkShrinkPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601772D RID: 96045 RVA: 0x0020E5F7 File Offset: 0x0020C7F7
		static vtkShrinkPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShrinkPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShrinkPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601772E RID: 96046 RVA: 0x0020E61F File Offset: 0x0020C81F
		public vtkShrinkPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601772F RID: 96047
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShrinkPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017730 RID: 96048 RVA: 0x0020E630 File Offset: 0x0020C830
		public new static vtkShrinkPolyData New()
		{
			vtkShrinkPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShrinkPolyData.vtkShrinkPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShrinkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017731 RID: 96049 RVA: 0x0020E684 File Offset: 0x0020C884
		public vtkShrinkPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkShrinkPolyData.vtkShrinkPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017732 RID: 96050 RVA: 0x0020E6C8 File Offset: 0x0020C8C8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017733 RID: 96051
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShrinkPolyData_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017734 RID: 96052 RVA: 0x0020E6D4 File Offset: 0x0020C8D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkShrinkPolyData.vtkShrinkPolyData_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06017735 RID: 96053
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkShrinkPolyData_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017736 RID: 96054 RVA: 0x0020E6F4 File Offset: 0x0020C8F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkShrinkPolyData.vtkShrinkPolyData_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06017737 RID: 96055
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShrinkPolyData_GetShrinkFactor_03(HandleRef pThis);

		/// <summary>
		/// Get the fraction of shrink for each cell.
		/// </summary>
		// Token: 0x06017738 RID: 96056 RVA: 0x0020E710 File Offset: 0x0020C910
		public virtual double GetShrinkFactor()
		{
			return vtkShrinkPolyData.vtkShrinkPolyData_GetShrinkFactor_03(base.GetCppThis());
		}

		// Token: 0x06017739 RID: 96057
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShrinkPolyData_GetShrinkFactorMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set the fraction of shrink for each cell.
		/// </summary>
		// Token: 0x0601773A RID: 96058 RVA: 0x0020E730 File Offset: 0x0020C930
		public virtual double GetShrinkFactorMaxValue()
		{
			return vtkShrinkPolyData.vtkShrinkPolyData_GetShrinkFactorMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0601773B RID: 96059
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkShrinkPolyData_GetShrinkFactorMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set the fraction of shrink for each cell.
		/// </summary>
		// Token: 0x0601773C RID: 96060 RVA: 0x0020E750 File Offset: 0x0020C950
		public virtual double GetShrinkFactorMinValue()
		{
			return vtkShrinkPolyData.vtkShrinkPolyData_GetShrinkFactorMinValue_05(base.GetCppThis());
		}

		// Token: 0x0601773D RID: 96061
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShrinkPolyData_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601773E RID: 96062 RVA: 0x0020E770 File Offset: 0x0020C970
		public override int IsA(string type)
		{
			return vtkShrinkPolyData.vtkShrinkPolyData_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0601773F RID: 96063
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkShrinkPolyData_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017740 RID: 96064 RVA: 0x0020E790 File Offset: 0x0020C990
		public new static int IsTypeOf(string type)
		{
			return vtkShrinkPolyData.vtkShrinkPolyData_IsTypeOf_07(type);
		}

		// Token: 0x06017741 RID: 96065
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShrinkPolyData_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017742 RID: 96066 RVA: 0x0020E7AC File Offset: 0x0020C9AC
		public new vtkShrinkPolyData NewInstance()
		{
			vtkShrinkPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShrinkPolyData.vtkShrinkPolyData_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShrinkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017743 RID: 96067
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkShrinkPolyData_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017744 RID: 96068 RVA: 0x0020E808 File Offset: 0x0020CA08
		public new static vtkShrinkPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkShrinkPolyData vtkShrinkPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkShrinkPolyData.vtkShrinkPolyData_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShrinkPolyData = (vtkShrinkPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShrinkPolyData.Register(null);
				}
			}
			return vtkShrinkPolyData;
		}

		// Token: 0x06017745 RID: 96069
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkShrinkPolyData_SetShrinkFactor_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the fraction of shrink for each cell.
		/// </summary>
		// Token: 0x06017746 RID: 96070 RVA: 0x0020E887 File Offset: 0x0020CA87
		public virtual void SetShrinkFactor(double _arg)
		{
			vtkShrinkPolyData.vtkShrinkPolyData_SetShrinkFactor_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A2F RID: 6703
		public new const string MRFullTypeName = "Kitware.VTK.vtkShrinkPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A30 RID: 6704
		public new static readonly string MRClassNameKey = "class vtkShrinkPolyData";
	}
}
