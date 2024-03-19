using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRecursiveDividingCubes
	/// </summary>
	/// <remarks>
	///    create points laying on isosurface (using recursive approach)
	///
	/// vtkRecursiveDividingCubes is a filter that generates points laying on a
	/// surface of constant scalar value (i.e., an isosurface). Dense point
	/// clouds (i.e., at screen resolution) will appear as a surface. Less dense
	/// clouds can be used as a source to generate streamlines or to generate
	/// "transparent" surfaces.
	///
	/// This implementation differs from vtkDividingCubes in that it uses a
	/// recursive procedure. In many cases this can result in generating
	/// more points than the procedural implementation of vtkDividingCubes. This is
	/// because the recursive procedure divides voxels by multiples of powers of
	/// two. This can over-constrain subdivision. One of the advantages of the
	/// recursive technique is that the recursion is terminated earlier, which in
	/// some cases can be more efficient.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkDividingCubes vtkContourFilter vtkMarchingCubes
	/// </seealso>
	// Token: 0x020008D7 RID: 2263
	public class vtkRecursiveDividingCubes : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017663 RID: 95843 RVA: 0x0020D357 File Offset: 0x0020B557
		static vtkRecursiveDividingCubes()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRecursiveDividingCubes.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRecursiveDividingCubes"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017664 RID: 95844 RVA: 0x0020D37F File Offset: 0x0020B57F
		public vtkRecursiveDividingCubes(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017665 RID: 95845
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRecursiveDividingCubes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017666 RID: 95846 RVA: 0x0020D390 File Offset: 0x0020B590
		public new static vtkRecursiveDividingCubes New()
		{
			vtkRecursiveDividingCubes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRecursiveDividingCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017667 RID: 95847 RVA: 0x0020D3E4 File Offset: 0x0020B5E4
		public vtkRecursiveDividingCubes() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017668 RID: 95848 RVA: 0x0020D428 File Offset: 0x0020B628
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017669 RID: 95849
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRecursiveDividingCubes_GetDistance_01(HandleRef pThis);

		/// <summary>
		/// Specify sub-voxel size at which to generate point.
		/// </summary>
		// Token: 0x0601766A RID: 95850 RVA: 0x0020D434 File Offset: 0x0020B634
		public virtual double GetDistance()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetDistance_01(base.GetCppThis());
		}

		// Token: 0x0601766B RID: 95851
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRecursiveDividingCubes_GetDistanceMaxValue_02(HandleRef pThis);

		/// <summary>
		/// Specify sub-voxel size at which to generate point.
		/// </summary>
		// Token: 0x0601766C RID: 95852 RVA: 0x0020D454 File Offset: 0x0020B654
		public virtual double GetDistanceMaxValue()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetDistanceMaxValue_02(base.GetCppThis());
		}

		// Token: 0x0601766D RID: 95853
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRecursiveDividingCubes_GetDistanceMinValue_03(HandleRef pThis);

		/// <summary>
		/// Specify sub-voxel size at which to generate point.
		/// </summary>
		// Token: 0x0601766E RID: 95854 RVA: 0x0020D474 File Offset: 0x0020B674
		public virtual double GetDistanceMinValue()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetDistanceMinValue_03(base.GetCppThis());
		}

		// Token: 0x0601766F RID: 95855
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecursiveDividingCubes_GetIncrement_04(HandleRef pThis);

		/// <summary>
		/// Every "Increment" point is added to the list of points. This parameter, if
		/// set to a large value, can be used to limit the number of points while
		/// retaining good accuracy.
		/// </summary>
		// Token: 0x06017670 RID: 95856 RVA: 0x0020D494 File Offset: 0x0020B694
		public virtual int GetIncrement()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetIncrement_04(base.GetCppThis());
		}

		// Token: 0x06017671 RID: 95857
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecursiveDividingCubes_GetIncrementMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Every "Increment" point is added to the list of points. This parameter, if
		/// set to a large value, can be used to limit the number of points while
		/// retaining good accuracy.
		/// </summary>
		// Token: 0x06017672 RID: 95858 RVA: 0x0020D4B4 File Offset: 0x0020B6B4
		public virtual int GetIncrementMaxValue()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetIncrementMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06017673 RID: 95859
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecursiveDividingCubes_GetIncrementMinValue_06(HandleRef pThis);

		/// <summary>
		/// Every "Increment" point is added to the list of points. This parameter, if
		/// set to a large value, can be used to limit the number of points while
		/// retaining good accuracy.
		/// </summary>
		// Token: 0x06017674 RID: 95860 RVA: 0x0020D4D4 File Offset: 0x0020B6D4
		public virtual int GetIncrementMinValue()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetIncrementMinValue_06(base.GetCppThis());
		}

		// Token: 0x06017675 RID: 95861
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRecursiveDividingCubes_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017676 RID: 95862 RVA: 0x0020D4F4 File Offset: 0x0020B6F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06017677 RID: 95863
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRecursiveDividingCubes_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017678 RID: 95864 RVA: 0x0020D514 File Offset: 0x0020B714
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06017679 RID: 95865
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRecursiveDividingCubes_GetValue_09(HandleRef pThis);

		/// <summary>
		/// Set isosurface value.
		/// </summary>
		// Token: 0x0601767A RID: 95866 RVA: 0x0020D530 File Offset: 0x0020B730
		public virtual double GetValue()
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_GetValue_09(base.GetCppThis());
		}

		// Token: 0x0601767B RID: 95867
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecursiveDividingCubes_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601767C RID: 95868 RVA: 0x0020D550 File Offset: 0x0020B750
		public override int IsA(string type)
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0601767D RID: 95869
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRecursiveDividingCubes_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601767E RID: 95870 RVA: 0x0020D570 File Offset: 0x0020B770
		public new static int IsTypeOf(string type)
		{
			return vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_IsTypeOf_11(type);
		}

		// Token: 0x0601767F RID: 95871
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRecursiveDividingCubes_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017680 RID: 95872 RVA: 0x0020D58C File Offset: 0x0020B78C
		public new vtkRecursiveDividingCubes NewInstance()
		{
			vtkRecursiveDividingCubes result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRecursiveDividingCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017681 RID: 95873
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRecursiveDividingCubes_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017682 RID: 95874 RVA: 0x0020D5E8 File Offset: 0x0020B7E8
		public new static vtkRecursiveDividingCubes SafeDownCast(vtkObjectBase o)
		{
			vtkRecursiveDividingCubes vtkRecursiveDividingCubes = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRecursiveDividingCubes = (vtkRecursiveDividingCubes)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRecursiveDividingCubes.Register(null);
				}
			}
			return vtkRecursiveDividingCubes;
		}

		// Token: 0x06017683 RID: 95875
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRecursiveDividingCubes_SetDistance_15(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify sub-voxel size at which to generate point.
		/// </summary>
		// Token: 0x06017684 RID: 95876 RVA: 0x0020D667 File Offset: 0x0020B867
		public virtual void SetDistance(double _arg)
		{
			vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_SetDistance_15(base.GetCppThis(), _arg);
		}

		// Token: 0x06017685 RID: 95877
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRecursiveDividingCubes_SetIncrement_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Every "Increment" point is added to the list of points. This parameter, if
		/// set to a large value, can be used to limit the number of points while
		/// retaining good accuracy.
		/// </summary>
		// Token: 0x06017686 RID: 95878 RVA: 0x0020D677 File Offset: 0x0020B877
		public virtual void SetIncrement(int _arg)
		{
			vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_SetIncrement_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06017687 RID: 95879
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRecursiveDividingCubes_SetValue_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Set isosurface value.
		/// </summary>
		// Token: 0x06017688 RID: 95880 RVA: 0x0020D687 File Offset: 0x0020B887
		public virtual void SetValue(double _arg)
		{
			vtkRecursiveDividingCubes.vtkRecursiveDividingCubes_SetValue_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A21 RID: 6689
		public new const string MRFullTypeName = "Kitware.VTK.vtkRecursiveDividingCubes";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A22 RID: 6690
		public new static readonly string MRClassNameKey = "class vtkRecursiveDividingCubes";
	}
}
