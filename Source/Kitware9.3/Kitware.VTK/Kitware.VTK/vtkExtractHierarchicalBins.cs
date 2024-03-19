using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractHierarchicalBins
	/// </summary>
	/// <remarks>
	///    manipulate the output of
	/// vtkHierarchicalBinningFilter
	///
	///
	/// vtkExtractHierarchicalBins enables users to extract data from the output
	/// of vtkHierarchicalBinningFilter. Points at a particular level, or at a
	/// level and bin number, can be filtered to the output. To perform these
	/// operations, the output must contain points sorted into bins (the
	/// vtkPoints), with offsets pointing to the beginning of each bin (a
	/// vtkFieldData array named "BinOffsets").
	///
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFiltersPointsFilter vtkRadiusOutlierRemoval vtkStatisticalOutlierRemoval
	/// vtkThresholdPoints vtkImplicitFunction vtkExtractGeometry
	/// vtkFitImplicitFunction
	/// </seealso>
	// Token: 0x02000440 RID: 1088
	public class vtkExtractHierarchicalBins : vtkPointCloudFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CB55 RID: 52053 RVA: 0x0011ACC3 File Offset: 0x00118EC3
		static vtkExtractHierarchicalBins()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractHierarchicalBins.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractHierarchicalBins"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CB56 RID: 52054 RVA: 0x0011ACEB File Offset: 0x00118EEB
		public vtkExtractHierarchicalBins(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CB57 RID: 52055
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHierarchicalBins_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CB58 RID: 52056 RVA: 0x0011ACFC File Offset: 0x00118EFC
		public new static vtkExtractHierarchicalBins New()
		{
			vtkExtractHierarchicalBins result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractHierarchicalBins)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CB59 RID: 52057 RVA: 0x0011AD50 File Offset: 0x00118F50
		public vtkExtractHierarchicalBins() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CB5A RID: 52058 RVA: 0x0011AD94 File Offset: 0x00118F94
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CB5B RID: 52059
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHierarchicalBins_GetBin_01(HandleRef pThis);

		/// <summary>
		/// Specify the bin number to extract. If a non-negative value, then the
		/// points from the bin number specified are extracted. If negative, then
		/// entire levels of points are extacted (assuming the Level is
		/// non-negative). Note that the bin tree is flattened, a particular bin
		/// number may refer to a bin on any level. Note that requesting a bin
		/// greater than the associated vtkHierarchicalBinningFilter will clamp the
		/// bin to the maximum possible bin of the binning filter.
		/// </summary>
		// Token: 0x0600CB5C RID: 52060 RVA: 0x0011ADA0 File Offset: 0x00118FA0
		public virtual int GetBin()
		{
			return vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_GetBin_01(base.GetCppThis());
		}

		// Token: 0x0600CB5D RID: 52061
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHierarchicalBins_GetBinningFilter_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the vtkHierarchicalBinningFilter to query for relevant
		/// information. Make sure that this filter has executed prior to the execution of
		/// this filter. (This is generally a safe bet if connected in a pipeline.)
		/// </summary>
		// Token: 0x0600CB5E RID: 52062 RVA: 0x0011ADC0 File Offset: 0x00118FC0
		public virtual vtkHierarchicalBinningFilter GetBinningFilter()
		{
			vtkHierarchicalBinningFilter vtkHierarchicalBinningFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_GetBinningFilter_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHierarchicalBinningFilter = (vtkHierarchicalBinningFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHierarchicalBinningFilter.Register(null);
				}
			}
			return vtkHierarchicalBinningFilter;
		}

		// Token: 0x0600CB5F RID: 52063
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHierarchicalBins_GetLevel_03(HandleRef pThis);

		/// <summary>
		/// Specify the level to extract. If non-negative, with a negative bin
		/// number, then all points at this level are extracted and sent to the
		/// output. If negative, then the points from the specified bin are sent to
		/// the output. If both the level and bin number are negative values, then
		/// the input is sent to the output. By default the 0th level is
		/// extracted. Note that requesting a level greater than the associated
		/// vtkHierarchicalBinningFilter will clamp the level to the maximum
		/// possible level of the binning filter.
		/// </summary>
		// Token: 0x0600CB60 RID: 52064 RVA: 0x0011AE30 File Offset: 0x00119030
		public virtual int GetLevel()
		{
			return vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_GetLevel_03(base.GetCppThis());
		}

		// Token: 0x0600CB61 RID: 52065
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractHierarchicalBins_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CB62 RID: 52066 RVA: 0x0011AE50 File Offset: 0x00119050
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0600CB63 RID: 52067
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractHierarchicalBins_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CB64 RID: 52068 RVA: 0x0011AE70 File Offset: 0x00119070
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0600CB65 RID: 52069
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHierarchicalBins_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CB66 RID: 52070 RVA: 0x0011AE8C File Offset: 0x0011908C
		public override int IsA(string type)
		{
			return vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x0600CB67 RID: 52071
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractHierarchicalBins_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CB68 RID: 52072 RVA: 0x0011AEAC File Offset: 0x001190AC
		public new static int IsTypeOf(string type)
		{
			return vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_IsTypeOf_07(type);
		}

		// Token: 0x0600CB69 RID: 52073
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHierarchicalBins_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CB6A RID: 52074 RVA: 0x0011AEC8 File Offset: 0x001190C8
		public new vtkExtractHierarchicalBins NewInstance()
		{
			vtkExtractHierarchicalBins result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractHierarchicalBins)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CB6B RID: 52075
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractHierarchicalBins_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiating, obtaining type information, and
		/// printing information.
		/// </summary>
		// Token: 0x0600CB6C RID: 52076 RVA: 0x0011AF24 File Offset: 0x00119124
		public new static vtkExtractHierarchicalBins SafeDownCast(vtkObjectBase o)
		{
			vtkExtractHierarchicalBins vtkExtractHierarchicalBins = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractHierarchicalBins = (vtkExtractHierarchicalBins)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractHierarchicalBins.Register(null);
				}
			}
			return vtkExtractHierarchicalBins;
		}

		// Token: 0x0600CB6D RID: 52077
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHierarchicalBins_SetBin_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the bin number to extract. If a non-negative value, then the
		/// points from the bin number specified are extracted. If negative, then
		/// entire levels of points are extacted (assuming the Level is
		/// non-negative). Note that the bin tree is flattened, a particular bin
		/// number may refer to a bin on any level. Note that requesting a bin
		/// greater than the associated vtkHierarchicalBinningFilter will clamp the
		/// bin to the maximum possible bin of the binning filter.
		/// </summary>
		// Token: 0x0600CB6E RID: 52078 RVA: 0x0011AFA3 File Offset: 0x001191A3
		public virtual void SetBin(int _arg)
		{
			vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_SetBin_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0600CB6F RID: 52079
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHierarchicalBins_SetBinningFilter_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the vtkHierarchicalBinningFilter to query for relevant
		/// information. Make sure that this filter has executed prior to the execution of
		/// this filter. (This is generally a safe bet if connected in a pipeline.)
		/// </summary>
		// Token: 0x0600CB70 RID: 52080 RVA: 0x0011AFB4 File Offset: 0x001191B4
		public virtual void SetBinningFilter(vtkHierarchicalBinningFilter arg0)
		{
			vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_SetBinningFilter_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600CB71 RID: 52081
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractHierarchicalBins_SetLevel_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify the level to extract. If non-negative, with a negative bin
		/// number, then all points at this level are extracted and sent to the
		/// output. If negative, then the points from the specified bin are sent to
		/// the output. If both the level and bin number are negative values, then
		/// the input is sent to the output. By default the 0th level is
		/// extracted. Note that requesting a level greater than the associated
		/// vtkHierarchicalBinningFilter will clamp the level to the maximum
		/// possible level of the binning filter.
		/// </summary>
		// Token: 0x0600CB72 RID: 52082 RVA: 0x0011AFE3 File Offset: 0x001191E3
		public virtual void SetLevel(int _arg)
		{
			vtkExtractHierarchicalBins.vtkExtractHierarchicalBins_SetLevel_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F0D RID: 3853
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractHierarchicalBins";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F0E RID: 3854
		public new static readonly string MRClassNameKey = "class vtkExtractHierarchicalBins";
	}
}
