using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRadiusOutlierRemoval
	/// </summary>
	/// <remarks>
	///    remove isolated points
	///
	///
	/// vtkRadiusOutlierRemoval removes isolated points; i.e., those points that
	/// have few neighbors within a specified radius. The user must specify the
	/// radius defining the local region, as well as the isolation threshold
	/// (i.e., number of neighboring points required for the point to be
	/// considered isolated). Optionally, users can specify a point locator to
	/// accelerate local neighborhood search operations. (By default a
	/// vtkStaticPointLocator will be created.)
	///
	/// Note that while any vtkPointSet type can be provided as input, the output
	/// is represented by an explicit representation of points via a
	/// vtkPolyData. This output polydata will populate its instance of vtkPoints,
	/// but no cells will be defined (i.e., no vtkVertex or vtkPolyVertex are
	/// contained in the output). Also, after filter execution, the user can
	/// request a vtkIdType* map which indicates how the input points were mapped
	/// to the output. A value of map[i] (where i is the ith input point) less
	/// than 0 means that the ith input point was removed. (See also the
	/// superclass documentation for accessing the removed points through the
	/// filter's second output.)
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointCloudFilter vtkStatisticalOutlierRemoval vtkExtractPoints
	/// vtkThresholdPoints vtkImplicitFunction
	/// </seealso>
	// Token: 0x0200045B RID: 1115
	public class vtkRadiusOutlierRemoval : vtkPointCloudFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CF41 RID: 53057 RVA: 0x001202D5 File Offset: 0x0011E4D5
		static vtkRadiusOutlierRemoval()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRadiusOutlierRemoval.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRadiusOutlierRemoval"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CF42 RID: 53058 RVA: 0x001202FD File Offset: 0x0011E4FD
		public vtkRadiusOutlierRemoval(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CF43 RID: 53059
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRadiusOutlierRemoval_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CF44 RID: 53060 RVA: 0x0012030C File Offset: 0x0011E50C
		public new static vtkRadiusOutlierRemoval New()
		{
			vtkRadiusOutlierRemoval result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRadiusOutlierRemoval)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CF45 RID: 53061 RVA: 0x00120360 File Offset: 0x0011E560
		public vtkRadiusOutlierRemoval() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CF46 RID: 53062 RVA: 0x001203A4 File Offset: 0x0011E5A4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CF47 RID: 53063
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRadiusOutlierRemoval_GetLocator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate near a
		/// specified interpolation position.
		/// </summary>
		// Token: 0x0600CF48 RID: 53064 RVA: 0x001203B0 File Offset: 0x0011E5B0
		public virtual vtkAbstractPointLocator GetLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_GetLocator_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPointLocator = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPointLocator.Register(null);
				}
			}
			return vtkAbstractPointLocator;
		}

		// Token: 0x0600CF49 RID: 53065
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRadiusOutlierRemoval_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CF4A RID: 53066 RVA: 0x00120420 File Offset: 0x0011E620
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600CF4B RID: 53067
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRadiusOutlierRemoval_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CF4C RID: 53068 RVA: 0x00120440 File Offset: 0x0011E640
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600CF4D RID: 53069
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRadiusOutlierRemoval_GetNumberOfNeighbors_04(HandleRef pThis);

		/// <summary>
		/// Specify the number of neighbors that a point must have, within
		/// the specified radius, for the point to not be considered isolated.
		/// </summary>
		// Token: 0x0600CF4E RID: 53070 RVA: 0x0012045C File Offset: 0x0011E65C
		public virtual int GetNumberOfNeighbors()
		{
			return vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_GetNumberOfNeighbors_04(base.GetCppThis());
		}

		// Token: 0x0600CF4F RID: 53071
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRadiusOutlierRemoval_GetNumberOfNeighborsMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Specify the number of neighbors that a point must have, within
		/// the specified radius, for the point to not be considered isolated.
		/// </summary>
		// Token: 0x0600CF50 RID: 53072 RVA: 0x0012047C File Offset: 0x0011E67C
		public virtual int GetNumberOfNeighborsMaxValue()
		{
			return vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_GetNumberOfNeighborsMaxValue_05(base.GetCppThis());
		}

		// Token: 0x0600CF51 RID: 53073
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRadiusOutlierRemoval_GetNumberOfNeighborsMinValue_06(HandleRef pThis);

		/// <summary>
		/// Specify the number of neighbors that a point must have, within
		/// the specified radius, for the point to not be considered isolated.
		/// </summary>
		// Token: 0x0600CF52 RID: 53074 RVA: 0x0012049C File Offset: 0x0011E69C
		public virtual int GetNumberOfNeighborsMinValue()
		{
			return vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_GetNumberOfNeighborsMinValue_06(base.GetCppThis());
		}

		// Token: 0x0600CF53 RID: 53075
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRadiusOutlierRemoval_GetRadius_07(HandleRef pThis);

		/// <summary>
		/// Specify the local search radius.
		/// </summary>
		// Token: 0x0600CF54 RID: 53076 RVA: 0x001204BC File Offset: 0x0011E6BC
		public virtual double GetRadius()
		{
			return vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_GetRadius_07(base.GetCppThis());
		}

		// Token: 0x0600CF55 RID: 53077
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRadiusOutlierRemoval_GetRadiusMaxValue_08(HandleRef pThis);

		/// <summary>
		/// Specify the local search radius.
		/// </summary>
		// Token: 0x0600CF56 RID: 53078 RVA: 0x001204DC File Offset: 0x0011E6DC
		public virtual double GetRadiusMaxValue()
		{
			return vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_GetRadiusMaxValue_08(base.GetCppThis());
		}

		// Token: 0x0600CF57 RID: 53079
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkRadiusOutlierRemoval_GetRadiusMinValue_09(HandleRef pThis);

		/// <summary>
		/// Specify the local search radius.
		/// </summary>
		// Token: 0x0600CF58 RID: 53080 RVA: 0x001204FC File Offset: 0x0011E6FC
		public virtual double GetRadiusMinValue()
		{
			return vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_GetRadiusMinValue_09(base.GetCppThis());
		}

		// Token: 0x0600CF59 RID: 53081
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRadiusOutlierRemoval_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CF5A RID: 53082 RVA: 0x0012051C File Offset: 0x0011E71C
		public override int IsA(string type)
		{
			return vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x0600CF5B RID: 53083
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRadiusOutlierRemoval_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CF5C RID: 53084 RVA: 0x0012053C File Offset: 0x0011E73C
		public new static int IsTypeOf(string type)
		{
			return vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_IsTypeOf_11(type);
		}

		// Token: 0x0600CF5D RID: 53085
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRadiusOutlierRemoval_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CF5E RID: 53086 RVA: 0x00120558 File Offset: 0x0011E758
		public new vtkRadiusOutlierRemoval NewInstance()
		{
			vtkRadiusOutlierRemoval result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRadiusOutlierRemoval)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CF5F RID: 53087
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRadiusOutlierRemoval_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CF60 RID: 53088 RVA: 0x001205B4 File Offset: 0x0011E7B4
		public new static vtkRadiusOutlierRemoval SafeDownCast(vtkObjectBase o)
		{
			vtkRadiusOutlierRemoval vtkRadiusOutlierRemoval = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRadiusOutlierRemoval = (vtkRadiusOutlierRemoval)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRadiusOutlierRemoval.Register(null);
				}
			}
			return vtkRadiusOutlierRemoval;
		}

		// Token: 0x0600CF61 RID: 53089
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRadiusOutlierRemoval_SetLocator_15(HandleRef pThis, HandleRef locator);

		/// <summary>
		/// Specify a point locator. By default a vtkStaticPointLocator is
		/// used. The locator performs efficient searches to locate near a
		/// specified interpolation position.
		/// </summary>
		// Token: 0x0600CF62 RID: 53090 RVA: 0x00120634 File Offset: 0x0011E834
		public void SetLocator(vtkAbstractPointLocator locator)
		{
			vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_SetLocator_15(base.GetCppThis(), (locator == null) ? default(HandleRef) : locator.GetCppThis());
		}

		// Token: 0x0600CF63 RID: 53091
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRadiusOutlierRemoval_SetNumberOfNeighbors_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the number of neighbors that a point must have, within
		/// the specified radius, for the point to not be considered isolated.
		/// </summary>
		// Token: 0x0600CF64 RID: 53092 RVA: 0x00120663 File Offset: 0x0011E863
		public virtual void SetNumberOfNeighbors(int _arg)
		{
			vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_SetNumberOfNeighbors_16(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CF65 RID: 53093
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkRadiusOutlierRemoval_SetRadius_17(HandleRef pThis, double _arg);

		/// <summary>
		/// Specify the local search radius.
		/// </summary>
		// Token: 0x0600CF66 RID: 53094 RVA: 0x00120673 File Offset: 0x0011E873
		public virtual void SetRadius(double _arg)
		{
			vtkRadiusOutlierRemoval.vtkRadiusOutlierRemoval_SetRadius_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F54 RID: 3924
		public new const string MRFullTypeName = "Kitware.VTK.vtkRadiusOutlierRemoval";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F55 RID: 3925
		public new static readonly string MRClassNameKey = "class vtkRadiusOutlierRemoval";
	}
}
