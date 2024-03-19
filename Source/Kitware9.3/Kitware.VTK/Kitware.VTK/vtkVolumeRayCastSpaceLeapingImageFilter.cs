using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVolumeRayCastSpaceLeapingImageFilter
	/// </summary>
	/// <remarks>
	///    Builds the space leaping data structure.
	///
	/// This is an optimized multi-threaded imaging filter that builds the space
	/// leaping datastructure, used by vtkFixedPointVolumeRayCastMapper. Empty
	/// space leaping is used to skip large empty regions in the scalar
	/// opacity and/or the gradient opacity transfer functions. Depending on
	/// the various options set by vtkFixedPointVolumeRayCastMapper, the class
	/// will internally invoke one of the many optimized routines to compute the
	/// min/max/gradient-max values within a fixed block size, trying to
	/// compute everything in a single multi-threaded pass through the data
	///
	/// The block size may be changed at compile time. Its ifdef'ed to 4 in the CXX
	/// file.
	/// </remarks>
	// Token: 0x020003AF RID: 943
	public class vtkVolumeRayCastSpaceLeapingImageFilter : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600ABB6 RID: 43958 RVA: 0x000F3DAB File Offset: 0x000F1FAB
		static vtkVolumeRayCastSpaceLeapingImageFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVolumeRayCastSpaceLeapingImageFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeRayCastSpaceLeapingImageFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600ABB7 RID: 43959 RVA: 0x000F3DD3 File Offset: 0x000F1FD3
		public vtkVolumeRayCastSpaceLeapingImageFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600ABB8 RID: 43960
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABB9 RID: 43961 RVA: 0x000F3DE4 File Offset: 0x000F1FE4
		public new static vtkVolumeRayCastSpaceLeapingImageFilter New()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRayCastSpaceLeapingImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABBA RID: 43962 RVA: 0x000F3E38 File Offset: 0x000F2038
		public vtkVolumeRayCastSpaceLeapingImageFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600ABBB RID: 43963 RVA: 0x000F3E7C File Offset: 0x000F207C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600ABBC RID: 43964
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeGradientOpacityOff_01(HandleRef pThis);

		/// <summary>
		/// Compute gradient opacity ?
		/// </summary>
		// Token: 0x0600ABBD RID: 43965 RVA: 0x000F3E87 File Offset: 0x000F2087
		public virtual void ComputeGradientOpacityOff()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_ComputeGradientOpacityOff_01(base.GetCppThis());
		}

		// Token: 0x0600ABBE RID: 43966
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeGradientOpacityOn_02(HandleRef pThis);

		/// <summary>
		/// Compute gradient opacity ?
		/// </summary>
		// Token: 0x0600ABBF RID: 43967 RVA: 0x000F3E96 File Offset: 0x000F2096
		public virtual void ComputeGradientOpacityOn()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_ComputeGradientOpacityOn_02(base.GetCppThis());
		}

		// Token: 0x0600ABC0 RID: 43968
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeInputExtentsForOutput_03(IntPtr inExt, IntPtr inDim, IntPtr outExt, HandleRef inData);

		/// <summary>
		/// Compute the extents and dimensions of the input that's required to
		/// generate an output min-max structure given by outExt.
		/// INTERNAL - Do not use
		/// </summary>
		// Token: 0x0600ABC1 RID: 43969 RVA: 0x000F3EA8 File Offset: 0x000F20A8
		public static void ComputeInputExtentsForOutput(IntPtr inExt, IntPtr inDim, IntPtr outExt, vtkImageData inData)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_ComputeInputExtentsForOutput_03(inExt, inDim, outExt, (inData == null) ? default(HandleRef) : inData.GetCppThis());
		}

		// Token: 0x0600ABC2 RID: 43970
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeMinMaxOff_04(HandleRef pThis);

		/// <summary>
		/// Compute the min max structure ?.
		/// </summary>
		// Token: 0x0600ABC3 RID: 43971 RVA: 0x000F3ED4 File Offset: 0x000F20D4
		public virtual void ComputeMinMaxOff()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_ComputeMinMaxOff_04(base.GetCppThis());
		}

		// Token: 0x0600ABC4 RID: 43972
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_ComputeMinMaxOn_05(HandleRef pThis);

		/// <summary>
		/// Compute the min max structure ?.
		/// </summary>
		// Token: 0x0600ABC5 RID: 43973 RVA: 0x000F3EE3 File Offset: 0x000F20E3
		public virtual void ComputeMinMaxOn()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_ComputeMinMaxOn_05(base.GetCppThis());
		}

		// Token: 0x0600ABC6 RID: 43974
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeRayCastSpaceLeapingImageFilter_ComputeOffset_06(HandleRef pThis, IntPtr ext, IntPtr wholeExt, int nComponents);

		/// <summary>
		/// INTERNAL - Do not use
		/// Compute the offset within an image of whole extents wholeExt, to access
		/// the data starting at extents ext.
		/// </summary>
		// Token: 0x0600ABC7 RID: 43975 RVA: 0x000F3EF4 File Offset: 0x000F20F4
		public long ComputeOffset(IntPtr ext, IntPtr wholeExt, int nComponents)
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_ComputeOffset_06(base.GetCppThis(), ext, wholeExt, nComponents);
		}

		// Token: 0x0600ABC8 RID: 43976
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetComputeGradientOpacity_07(HandleRef pThis);

		/// <summary>
		/// Compute gradient opacity ?
		/// </summary>
		// Token: 0x0600ABC9 RID: 43977 RVA: 0x000F3F18 File Offset: 0x000F2118
		public virtual int GetComputeGradientOpacity()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetComputeGradientOpacity_07(base.GetCppThis());
		}

		// Token: 0x0600ABCA RID: 43978
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetComputeMinMax_08(HandleRef pThis);

		/// <summary>
		/// Compute the min max structure ?.
		/// </summary>
		// Token: 0x0600ABCB RID: 43979 RVA: 0x000F3F38 File Offset: 0x000F2138
		public virtual int GetComputeMinMax()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetComputeMinMax_08(base.GetCppThis());
		}

		// Token: 0x0600ABCC RID: 43980
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetCurrentScalars_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the scalars.
		/// </summary>
		// Token: 0x0600ABCD RID: 43981 RVA: 0x000F3F58 File Offset: 0x000F2158
		public virtual vtkDataArray GetCurrentScalars()
		{
			vtkDataArray vtkDataArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetCurrentScalars_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataArray = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataArray.Register(null);
				}
			}
			return vtkDataArray;
		}

		// Token: 0x0600ABCE RID: 43982
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetIndependentComponents_10(HandleRef pThis);

		/// <summary>
		/// Do we use independent components, or dependent components ?
		/// </summary>
		// Token: 0x0600ABCF RID: 43983 RVA: 0x000F3FC8 File Offset: 0x000F21C8
		public virtual int GetIndependentComponents()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetIndependentComponents_10(base.GetCppThis());
		}

		// Token: 0x0600ABD0 RID: 43984
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkVolumeRayCastSpaceLeapingImageFilter_GetLastMinMaxBuildTime_11(HandleRef pThis);

		/// <summary>
		/// Get the last execution time. This is updated every
		/// time the scalars or the gradient opacity values are computed
		/// </summary>
		// Token: 0x0600ABD1 RID: 43985 RVA: 0x000F3FE8 File Offset: 0x000F21E8
		public ulong GetLastMinMaxBuildTime()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetLastMinMaxBuildTime_11(base.GetCppThis());
		}

		// Token: 0x0600ABD2 RID: 43986
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkVolumeRayCastSpaceLeapingImageFilter_GetLastMinMaxFlagTime_12(HandleRef pThis);

		/// <summary>
		/// Get the last execution time. This is updated every time the flags bits
		/// are re-computed.
		/// </summary>
		// Token: 0x0600ABD3 RID: 43987 RVA: 0x000F4008 File Offset: 0x000F2208
		public ulong GetLastMinMaxFlagTime()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetLastMinMaxFlagTime_12(base.GetCppThis());
		}

		// Token: 0x0600ABD4 RID: 43988
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetMinMaxVolume_13(HandleRef pThis, IntPtr dims);

		/// <summary>
		/// Get the raw pointer to the final computed space leaping datastructure.
		/// The result is only valid after Update() has been called on the filter.
		/// Note that this filter holds onto its memory. The dimensions of the min-
		/// max volume are in dims. The 4th value in the array indicates the number
		/// of independent components, (also queried via
		/// GetNumberOfIndependentComponents())
		/// </summary>
		// Token: 0x0600ABD5 RID: 43989 RVA: 0x000F4028 File Offset: 0x000F2228
		public IntPtr GetMinMaxVolume(IntPtr dims)
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetMinMaxVolume_13(base.GetCppThis(), dims);
		}

		// Token: 0x0600ABD6 RID: 43990
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetMinNonZeroGradientMagnitudeIndex_14(HandleRef pThis);

		/// <summary>
		/// Get the first non-zero scalar opacity and gradient opacity indices for
		/// each independent component
		/// INTERNAL - Do not use.
		/// </summary>
		// Token: 0x0600ABD7 RID: 43991 RVA: 0x000F4048 File Offset: 0x000F2248
		public IntPtr GetMinNonZeroGradientMagnitudeIndex()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetMinNonZeroGradientMagnitudeIndex_14(base.GetCppThis());
		}

		// Token: 0x0600ABD8 RID: 43992
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetMinNonZeroScalarIndex_15(HandleRef pThis);

		/// <summary>
		/// Get the first non-zero scalar opacity and gradient opacity indices for
		/// each independent component
		/// INTERNAL - Do not use.
		/// </summary>
		// Token: 0x0600ABD9 RID: 43993 RVA: 0x000F4068 File Offset: 0x000F2268
		public IntPtr GetMinNonZeroScalarIndex()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetMinNonZeroScalarIndex_15(base.GetCppThis());
		}

		// Token: 0x0600ABDA RID: 43994
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfGenerationsFromBase_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABDB RID: 43995 RVA: 0x000F4088 File Offset: 0x000F2288
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfGenerationsFromBase_16(base.GetCppThis(), type);
		}

		// Token: 0x0600ABDC RID: 43996
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfGenerationsFromBaseType_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABDD RID: 43997 RVA: 0x000F40A8 File Offset: 0x000F22A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfGenerationsFromBaseType_17(type);
		}

		// Token: 0x0600ABDE RID: 43998
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfIndependentComponents_18(HandleRef pThis);

		/// <summary>
		/// Get the number of independent components for which we need to keep track
		/// of min/max
		/// </summary>
		// Token: 0x0600ABDF RID: 43999 RVA: 0x000F40C4 File Offset: 0x000F22C4
		public int GetNumberOfIndependentComponents()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetNumberOfIndependentComponents_18(base.GetCppThis());
		}

		// Token: 0x0600ABE0 RID: 44000
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_19(HandleRef pThis);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600ABE1 RID: 44001 RVA: 0x000F40E4 File Offset: 0x000F22E4
		public virtual float[] GetTableScale()
		{
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_19(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600ABE2 RID: 44002
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_20(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600ABE3 RID: 44003 RVA: 0x000F412C File Offset: 0x000F232C
		public virtual void GetTableScale(ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_20(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x0600ABE4 RID: 44004
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600ABE5 RID: 44005 RVA: 0x000F4140 File Offset: 0x000F2340
		public virtual void GetTableScale(IntPtr _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableScale_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ABE6 RID: 44006
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_22(HandleRef pThis);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600ABE7 RID: 44007 RVA: 0x000F4150 File Offset: 0x000F2350
		public virtual float[] GetTableShift()
		{
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_22(base.GetCppThis());
			float[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new float[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600ABE8 RID: 44008
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_23(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600ABE9 RID: 44009 RVA: 0x000F4198 File Offset: 0x000F2398
		public virtual void GetTableShift(ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_23(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x0600ABEA RID: 44010
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600ABEB RID: 44011 RVA: 0x000F41AC File Offset: 0x000F23AC
		public virtual void GetTableShift(IntPtr _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableShift_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ABEC RID: 44012
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_25(HandleRef pThis);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600ABED RID: 44013 RVA: 0x000F41BC File Offset: 0x000F23BC
		public virtual int[] GetTableSize()
		{
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_25(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600ABEE RID: 44014
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_26(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600ABEF RID: 44015 RVA: 0x000F4204 File Offset: 0x000F2404
		public virtual void GetTableSize(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_26(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x0600ABF0 RID: 44016
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_27(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600ABF1 RID: 44017 RVA: 0x000F4218 File Offset: 0x000F2418
		public virtual void GetTableSize(IntPtr _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetTableSize_27(base.GetCppThis(), _arg);
		}

		// Token: 0x0600ABF2 RID: 44018
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_GetUpdateGradientOpacityFlags_28(HandleRef pThis);

		/// <summary>
		/// Update the gradient opacity flags. (The scalar opacity flags are always
		/// updated upon execution of this filter.)
		/// </summary>
		// Token: 0x0600ABF3 RID: 44019 RVA: 0x000F4228 File Offset: 0x000F2428
		public virtual int GetUpdateGradientOpacityFlags()
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_GetUpdateGradientOpacityFlags_28(base.GetCppThis());
		}

		// Token: 0x0600ABF4 RID: 44020
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_IsA_29(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABF5 RID: 44021 RVA: 0x000F4248 File Offset: 0x000F2448
		public override int IsA(string type)
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_IsA_29(base.GetCppThis(), type);
		}

		// Token: 0x0600ABF6 RID: 44022
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVolumeRayCastSpaceLeapingImageFilter_IsTypeOf_30([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABF7 RID: 44023 RVA: 0x000F4268 File Offset: 0x000F2468
		public new static int IsTypeOf(string type)
		{
			return vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_IsTypeOf_30(type);
		}

		// Token: 0x0600ABF8 RID: 44024
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABF9 RID: 44025 RVA: 0x000F4284 File Offset: 0x000F2484
		public new vtkVolumeRayCastSpaceLeapingImageFilter NewInstance()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_NewInstance_32(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVolumeRayCastSpaceLeapingImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600ABFA RID: 44026
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVolumeRayCastSpaceLeapingImageFilter_SafeDownCast_33(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600ABFB RID: 44027 RVA: 0x000F42E0 File Offset: 0x000F24E0
		public new static vtkVolumeRayCastSpaceLeapingImageFilter SafeDownCast(vtkObjectBase o)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter vtkVolumeRayCastSpaceLeapingImageFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SafeDownCast_33((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVolumeRayCastSpaceLeapingImageFilter = (vtkVolumeRayCastSpaceLeapingImageFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVolumeRayCastSpaceLeapingImageFilter.Register(null);
				}
			}
			return vtkVolumeRayCastSpaceLeapingImageFilter;
		}

		// Token: 0x0600ABFC RID: 44028
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetCache_34(HandleRef pThis, HandleRef imageCache);

		/// <summary>
		/// INTERNAL - Do not use
		/// Set the last cached min-max volume, as used by
		/// vtkFixedPointVolumeRayCastMapper.
		/// </summary>
		// Token: 0x0600ABFD RID: 44029 RVA: 0x000F4360 File Offset: 0x000F2560
		public virtual void SetCache(vtkImageData imageCache)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetCache_34(base.GetCppThis(), (imageCache == null) ? default(HandleRef) : imageCache.GetCppThis());
		}

		// Token: 0x0600ABFE RID: 44030
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetComputeGradientOpacity_35(HandleRef pThis, int _arg);

		/// <summary>
		/// Compute gradient opacity ?
		/// </summary>
		// Token: 0x0600ABFF RID: 44031 RVA: 0x000F438F File Offset: 0x000F258F
		public virtual void SetComputeGradientOpacity(int _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetComputeGradientOpacity_35(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC00 RID: 44032
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetComputeMinMax_36(HandleRef pThis, int _arg);

		/// <summary>
		/// Compute the min max structure ?.
		/// </summary>
		// Token: 0x0600AC01 RID: 44033 RVA: 0x000F439F File Offset: 0x000F259F
		public virtual void SetComputeMinMax(int _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetComputeMinMax_36(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC02 RID: 44034
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetCurrentScalars_37(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set the scalars.
		/// </summary>
		// Token: 0x0600AC03 RID: 44035 RVA: 0x000F43B0 File Offset: 0x000F25B0
		public virtual void SetCurrentScalars(vtkDataArray arg0)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetCurrentScalars_37(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600AC04 RID: 44036
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetGradientOpacityTable_38(HandleRef pThis, int c, IntPtr t);

		/// <summary>
		/// Set the scalar opacity and gradient opacity tables computed for each
		/// component by the vtkFixedPointVolumeRayCastMapper
		/// </summary>
		// Token: 0x0600AC05 RID: 44037 RVA: 0x000F43DF File Offset: 0x000F25DF
		public void SetGradientOpacityTable(int c, IntPtr t)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetGradientOpacityTable_38(base.GetCppThis(), c, t);
		}

		// Token: 0x0600AC06 RID: 44038
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetIndependentComponents_39(HandleRef pThis, int _arg);

		/// <summary>
		/// Do we use independent components, or dependent components ?
		/// </summary>
		// Token: 0x0600AC07 RID: 44039 RVA: 0x000F43F0 File Offset: 0x000F25F0
		public virtual void SetIndependentComponents(int _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetIndependentComponents_39(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC08 RID: 44040
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetScalarOpacityTable_40(HandleRef pThis, int c, IntPtr t);

		/// <summary>
		/// Set the scalar opacity and gradient opacity tables computed for each
		/// component by the vtkFixedPointVolumeRayCastMapper
		/// </summary>
		// Token: 0x0600AC09 RID: 44041 RVA: 0x000F4400 File Offset: 0x000F2600
		public void SetScalarOpacityTable(int c, IntPtr t)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetScalarOpacityTable_40(base.GetCppThis(), c, t);
		}

		// Token: 0x0600AC0A RID: 44042
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableScale_41(HandleRef pThis, float _arg1, float _arg2, float _arg3, float _arg4);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600AC0B RID: 44043 RVA: 0x000F4411 File Offset: 0x000F2611
		public virtual void SetTableScale(float _arg1, float _arg2, float _arg3, float _arg4)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetTableScale_41(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x0600AC0C RID: 44044
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableScale_42(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600AC0D RID: 44045 RVA: 0x000F4425 File Offset: 0x000F2625
		public virtual void SetTableScale(IntPtr _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetTableScale_42(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC0E RID: 44046
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableShift_43(HandleRef pThis, float _arg1, float _arg2, float _arg3, float _arg4);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600AC0F RID: 44047 RVA: 0x000F4435 File Offset: 0x000F2635
		public virtual void SetTableShift(float _arg1, float _arg2, float _arg3, float _arg4)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetTableShift_43(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x0600AC10 RID: 44048
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableShift_44(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600AC11 RID: 44049 RVA: 0x000F4449 File Offset: 0x000F2649
		public virtual void SetTableShift(IntPtr _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetTableShift_44(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC12 RID: 44050
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableSize_45(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600AC13 RID: 44051 RVA: 0x000F4459 File Offset: 0x000F2659
		public virtual void SetTableSize(int _arg1, int _arg2, int _arg3, int _arg4)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetTableSize_45(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x0600AC14 RID: 44052
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetTableSize_46(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Is the difference between max and min of the data less than 32768? If so,
		/// and if the data is not of float/double type, use a simple offset mapping.
		/// If the difference between max and min is 32768 or greater, or the data
		/// is of type float or double, we must use an offset / scaling mapping.
		/// In this case, the array size will be 32768 - we need to figure out the
		/// offset and scale factor.
		/// </summary>
		// Token: 0x0600AC15 RID: 44053 RVA: 0x000F446D File Offset: 0x000F266D
		public virtual void SetTableSize(IntPtr _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetTableSize_46(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC16 RID: 44054
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_SetUpdateGradientOpacityFlags_47(HandleRef pThis, int _arg);

		/// <summary>
		/// Update the gradient opacity flags. (The scalar opacity flags are always
		/// updated upon execution of this filter.)
		/// </summary>
		// Token: 0x0600AC17 RID: 44055 RVA: 0x000F447D File Offset: 0x000F267D
		public virtual void SetUpdateGradientOpacityFlags(int _arg)
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_SetUpdateGradientOpacityFlags_47(base.GetCppThis(), _arg);
		}

		// Token: 0x0600AC18 RID: 44056
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_UpdateGradientOpacityFlagsOff_48(HandleRef pThis);

		/// <summary>
		/// Update the gradient opacity flags. (The scalar opacity flags are always
		/// updated upon execution of this filter.)
		/// </summary>
		// Token: 0x0600AC19 RID: 44057 RVA: 0x000F448D File Offset: 0x000F268D
		public virtual void UpdateGradientOpacityFlagsOff()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_UpdateGradientOpacityFlagsOff_48(base.GetCppThis());
		}

		// Token: 0x0600AC1A RID: 44058
		[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVolumeRayCastSpaceLeapingImageFilter_UpdateGradientOpacityFlagsOn_49(HandleRef pThis);

		/// <summary>
		/// Update the gradient opacity flags. (The scalar opacity flags are always
		/// updated upon execution of this filter.)
		/// </summary>
		// Token: 0x0600AC1B RID: 44059 RVA: 0x000F449C File Offset: 0x000F269C
		public virtual void UpdateGradientOpacityFlagsOn()
		{
			vtkVolumeRayCastSpaceLeapingImageFilter.vtkVolumeRayCastSpaceLeapingImageFilter_UpdateGradientOpacityFlagsOn_49(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D93 RID: 3475
		public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeRayCastSpaceLeapingImageFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000D94 RID: 3476
		public new static readonly string MRClassNameKey = "class vtkVolumeRayCastSpaceLeapingImageFilter";
	}
}
