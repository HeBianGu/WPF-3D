using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSplitByCellScalarFilter
	/// </summary>
	/// <remarks>
	///    splits input dataset according an integer cell scalar array.
	///
	/// vtkSplitByCellScalarFilter is a filter that splits any dataset type
	/// according an integer cell scalar value (typically a material identifier) to
	/// a multiblock. Each block of the output contains cells that have the same
	/// scalar value. Output blocks will be of type vtkUnstructuredGrid except if
	/// input is of type vtkPolyData. In that case output blocks are of type
	/// vtkPolyData.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkThreshold
	///
	/// @par Thanks:
	/// This class was written by Joachim Pouderoux, Kitware 2016.
	/// </seealso>
	// Token: 0x020008E2 RID: 2274
	public class vtkSplitByCellScalarFilter : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060177ED RID: 96237 RVA: 0x0020F71D File Offset: 0x0020D91D
		static vtkSplitByCellScalarFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplitByCellScalarFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplitByCellScalarFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060177EE RID: 96238 RVA: 0x0020F745 File Offset: 0x0020D945
		public vtkSplitByCellScalarFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060177EF RID: 96239
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplitByCellScalarFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060177F0 RID: 96240 RVA: 0x0020F754 File Offset: 0x0020D954
		public new static vtkSplitByCellScalarFilter New()
		{
			vtkSplitByCellScalarFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplitByCellScalarFilter.vtkSplitByCellScalarFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplitByCellScalarFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060177F1 RID: 96241 RVA: 0x0020F7A8 File Offset: 0x0020D9A8
		public vtkSplitByCellScalarFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSplitByCellScalarFilter.vtkSplitByCellScalarFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060177F2 RID: 96242 RVA: 0x0020F7EC File Offset: 0x0020D9EC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060177F3 RID: 96243
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplitByCellScalarFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060177F4 RID: 96244 RVA: 0x0020F7F8 File Offset: 0x0020D9F8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSplitByCellScalarFilter.vtkSplitByCellScalarFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060177F5 RID: 96245
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplitByCellScalarFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060177F6 RID: 96246 RVA: 0x0020F818 File Offset: 0x0020DA18
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSplitByCellScalarFilter.vtkSplitByCellScalarFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060177F7 RID: 96247
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSplitByCellScalarFilter_GetPassAllPoints_03(HandleRef pThis);

		/// <summary>
		/// Specify if input points array must be passed to output blocks. If so,
		/// filter processing is faster but outblocks will contains more points than
		/// what is needed by the cells it owns. If not, a new points array is created
		/// for every block and it will only contains points for copied cells.
		/// Note that this function is only possible for PointSet datasets.
		/// The default is true.
		/// </summary>
		// Token: 0x060177F8 RID: 96248 RVA: 0x0020F834 File Offset: 0x0020DA34
		public virtual bool GetPassAllPoints()
		{
			return vtkSplitByCellScalarFilter.vtkSplitByCellScalarFilter_GetPassAllPoints_03(base.GetCppThis()) != 0;
		}

		// Token: 0x060177F9 RID: 96249
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplitByCellScalarFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060177FA RID: 96250 RVA: 0x0020F85C File Offset: 0x0020DA5C
		public override int IsA(string type)
		{
			return vtkSplitByCellScalarFilter.vtkSplitByCellScalarFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060177FB RID: 96251
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplitByCellScalarFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060177FC RID: 96252 RVA: 0x0020F87C File Offset: 0x0020DA7C
		public new static int IsTypeOf(string type)
		{
			return vtkSplitByCellScalarFilter.vtkSplitByCellScalarFilter_IsTypeOf_05(type);
		}

		// Token: 0x060177FD RID: 96253
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplitByCellScalarFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060177FE RID: 96254 RVA: 0x0020F898 File Offset: 0x0020DA98
		public new vtkSplitByCellScalarFilter NewInstance()
		{
			vtkSplitByCellScalarFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplitByCellScalarFilter.vtkSplitByCellScalarFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplitByCellScalarFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060177FF RID: 96255
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitByCellScalarFilter_PassAllPointsOff_08(HandleRef pThis);

		/// <summary>
		/// Specify if input points array must be passed to output blocks. If so,
		/// filter processing is faster but outblocks will contains more points than
		/// what is needed by the cells it owns. If not, a new points array is created
		/// for every block and it will only contains points for copied cells.
		/// Note that this function is only possible for PointSet datasets.
		/// The default is true.
		/// </summary>
		// Token: 0x06017800 RID: 96256 RVA: 0x0020F8F2 File Offset: 0x0020DAF2
		public virtual void PassAllPointsOff()
		{
			vtkSplitByCellScalarFilter.vtkSplitByCellScalarFilter_PassAllPointsOff_08(base.GetCppThis());
		}

		// Token: 0x06017801 RID: 96257
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitByCellScalarFilter_PassAllPointsOn_09(HandleRef pThis);

		/// <summary>
		/// Specify if input points array must be passed to output blocks. If so,
		/// filter processing is faster but outblocks will contains more points than
		/// what is needed by the cells it owns. If not, a new points array is created
		/// for every block and it will only contains points for copied cells.
		/// Note that this function is only possible for PointSet datasets.
		/// The default is true.
		/// </summary>
		// Token: 0x06017802 RID: 96258 RVA: 0x0020F901 File Offset: 0x0020DB01
		public virtual void PassAllPointsOn()
		{
			vtkSplitByCellScalarFilter.vtkSplitByCellScalarFilter_PassAllPointsOn_09(base.GetCppThis());
		}

		// Token: 0x06017803 RID: 96259
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplitByCellScalarFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017804 RID: 96260 RVA: 0x0020F910 File Offset: 0x0020DB10
		public new static vtkSplitByCellScalarFilter SafeDownCast(vtkObjectBase o)
		{
			vtkSplitByCellScalarFilter vtkSplitByCellScalarFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplitByCellScalarFilter.vtkSplitByCellScalarFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplitByCellScalarFilter = (vtkSplitByCellScalarFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplitByCellScalarFilter.Register(null);
				}
			}
			return vtkSplitByCellScalarFilter;
		}

		// Token: 0x06017805 RID: 96261
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitByCellScalarFilter_SetPassAllPoints_11(HandleRef pThis, byte _arg);

		/// <summary>
		/// Specify if input points array must be passed to output blocks. If so,
		/// filter processing is faster but outblocks will contains more points than
		/// what is needed by the cells it owns. If not, a new points array is created
		/// for every block and it will only contains points for copied cells.
		/// Note that this function is only possible for PointSet datasets.
		/// The default is true.
		/// </summary>
		// Token: 0x06017806 RID: 96262 RVA: 0x0020F98F File Offset: 0x0020DB8F
		public virtual void SetPassAllPoints(bool _arg)
		{
			vtkSplitByCellScalarFilter.vtkSplitByCellScalarFilter_SetPassAllPoints_11(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A39 RID: 6713
		public new const string MRFullTypeName = "Kitware.VTK.vtkSplitByCellScalarFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A3A RID: 6714
		public new static readonly string MRClassNameKey = "class vtkSplitByCellScalarFilter";
	}
}
