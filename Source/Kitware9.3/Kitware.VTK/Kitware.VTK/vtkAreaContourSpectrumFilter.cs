using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAreaContourSpectrumFilter
	/// </summary>
	/// <remarks>
	///    compute an approximation of the area
	/// contour signature (evolution of the area of the input surface along an arc of
	/// the Reeb graph).
	///
	/// The filter takes a vtkPolyData as an input (port 0), along with a
	/// vtkReebGraph (port 1).
	/// The Reeb graph arc to consider can be specified with SetArcId() (default: 0).
	/// The number of (evenly distributed) samples of the signature can be defined
	/// with SetNumberOfSamples() (default value: 100).
	/// The filter will first try to pull as a scalar field the vtkDataArray with Id
	/// 'FieldId' of the vtkPolyData, see SetFieldId (default: 0). The filter will
	/// abort if this field does not exist.
	///
	/// The filter outputs a vtkTable with the area contour signature
	/// approximation, each sample being evenly distributed in the function span of
	/// the arc.
	///
	/// This filter is a typical example for designing your own contour signature
	/// filter (with customized metrics). It also shows typical vtkReebGraph
	/// traversals.
	///
	/// Reference:
	/// C. Bajaj, V. Pascucci, D. Schikore,
	/// "The contour spectrum",
	/// IEEE Visualization, 167-174, 1997.
	/// </remarks>
	// Token: 0x02000872 RID: 2162
	public class vtkAreaContourSpectrumFilter : vtkDataObjectAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016714 RID: 91924 RVA: 0x001F8E73 File Offset: 0x001F7073
		static vtkAreaContourSpectrumFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAreaContourSpectrumFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAreaContourSpectrumFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016715 RID: 91925 RVA: 0x001F8E9B File Offset: 0x001F709B
		public vtkAreaContourSpectrumFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016716 RID: 91926
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaContourSpectrumFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016717 RID: 91927 RVA: 0x001F8EAC File Offset: 0x001F70AC
		public new static vtkAreaContourSpectrumFilter New()
		{
			vtkAreaContourSpectrumFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAreaContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016718 RID: 91928 RVA: 0x001F8F00 File Offset: 0x001F7100
		public vtkAreaContourSpectrumFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016719 RID: 91929 RVA: 0x001F8F44 File Offset: 0x001F7144
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601671A RID: 91930
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAreaContourSpectrumFilter_GetArcId_01(HandleRef pThis);

		/// <summary>
		/// Set the arc Id for which the contour signature has to be computed.
		/// Default value: 0
		/// </summary>
		// Token: 0x0601671B RID: 91931 RVA: 0x001F8F50 File Offset: 0x001F7150
		public virtual long GetArcId()
		{
			return vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_GetArcId_01(base.GetCppThis());
		}

		// Token: 0x0601671C RID: 91932
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAreaContourSpectrumFilter_GetFieldId_02(HandleRef pThis);

		/// <summary>
		/// Set the scalar field Id
		/// Default value: 0
		/// </summary>
		// Token: 0x0601671D RID: 91933 RVA: 0x001F8F70 File Offset: 0x001F7170
		public virtual long GetFieldId()
		{
			return vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_GetFieldId_02(base.GetCppThis());
		}

		// Token: 0x0601671E RID: 91934
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAreaContourSpectrumFilter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601671F RID: 91935 RVA: 0x001F8F90 File Offset: 0x001F7190
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06016720 RID: 91936
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAreaContourSpectrumFilter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016721 RID: 91937 RVA: 0x001F8FB0 File Offset: 0x001F71B0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06016722 RID: 91938
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAreaContourSpectrumFilter_GetNumberOfSamples_05(HandleRef pThis);

		/// <summary>
		/// Set the number of samples in the output signature
		/// Default value: 100
		/// </summary>
		// Token: 0x06016723 RID: 91939 RVA: 0x001F8FCC File Offset: 0x001F71CC
		public virtual int GetNumberOfSamples()
		{
			return vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_GetNumberOfSamples_05(base.GetCppThis());
		}

		// Token: 0x06016724 RID: 91940
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaContourSpectrumFilter_GetOutput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the scalar field Id
		/// Default value: 0
		/// </summary>
		// Token: 0x06016725 RID: 91941 RVA: 0x001F8FEC File Offset: 0x001F71EC
		public new vtkTable GetOutput()
		{
			vtkTable vtkTable = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_GetOutput_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTable = (vtkTable)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTable.Register(null);
				}
			}
			return vtkTable;
		}

		// Token: 0x06016726 RID: 91942
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAreaContourSpectrumFilter_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016727 RID: 91943 RVA: 0x001F905C File Offset: 0x001F725C
		public override int IsA(string type)
		{
			return vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06016728 RID: 91944
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAreaContourSpectrumFilter_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016729 RID: 91945 RVA: 0x001F907C File Offset: 0x001F727C
		public new static int IsTypeOf(string type)
		{
			return vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_IsTypeOf_08(type);
		}

		// Token: 0x0601672A RID: 91946
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaContourSpectrumFilter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601672B RID: 91947 RVA: 0x001F9098 File Offset: 0x001F7298
		public new vtkAreaContourSpectrumFilter NewInstance()
		{
			vtkAreaContourSpectrumFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAreaContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601672C RID: 91948
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAreaContourSpectrumFilter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601672D RID: 91949 RVA: 0x001F90F4 File Offset: 0x001F72F4
		public new static vtkAreaContourSpectrumFilter SafeDownCast(vtkObjectBase o)
		{
			vtkAreaContourSpectrumFilter vtkAreaContourSpectrumFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAreaContourSpectrumFilter = (vtkAreaContourSpectrumFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAreaContourSpectrumFilter.Register(null);
				}
			}
			return vtkAreaContourSpectrumFilter;
		}

		// Token: 0x0601672E RID: 91950
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaContourSpectrumFilter_SetArcId_12(HandleRef pThis, long _arg);

		/// <summary>
		/// Set the arc Id for which the contour signature has to be computed.
		/// Default value: 0
		/// </summary>
		// Token: 0x0601672F RID: 91951 RVA: 0x001F9173 File Offset: 0x001F7373
		public virtual void SetArcId(long _arg)
		{
			vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_SetArcId_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06016730 RID: 91952
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaContourSpectrumFilter_SetFieldId_13(HandleRef pThis, long _arg);

		/// <summary>
		/// Set the scalar field Id
		/// Default value: 0
		/// </summary>
		// Token: 0x06016731 RID: 91953 RVA: 0x001F9183 File Offset: 0x001F7383
		public virtual void SetFieldId(long _arg)
		{
			vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_SetFieldId_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06016732 RID: 91954
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAreaContourSpectrumFilter_SetNumberOfSamples_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of samples in the output signature
		/// Default value: 100
		/// </summary>
		// Token: 0x06016733 RID: 91955 RVA: 0x001F9193 File Offset: 0x001F7393
		public virtual void SetNumberOfSamples(int _arg)
		{
			vtkAreaContourSpectrumFilter.vtkAreaContourSpectrumFilter_SetNumberOfSamples_14(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400193A RID: 6458
		public new const string MRFullTypeName = "Kitware.VTK.vtkAreaContourSpectrumFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400193B RID: 6459
		public new static readonly string MRClassNameKey = "class vtkAreaContourSpectrumFilter";
	}
}
